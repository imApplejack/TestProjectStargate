using Stargate.Stargate;
using System.Runtime.CompilerServices;
using Stargate.SGGodot;
using Stargate;
using Stargate.Mock;
using Stargate.Stargate.Enum;
using System.Diagnostics;
using Stargate.Stargate.Event;
using Stargate.StateMachine;
using Stargate.Stargate.Card;

namespace TestProject1
{
    [TestClass]
    public class TestStargateGame
    {


        [TestMethod]
        public void TestLibrary()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(library);
            StargateGameMock.InitPlayersWithMock(stargateGame);


           HeroCharacterModel m =  (HeroCharacterModel)stargateGame.GameState.CardRepository.Cards[15];


            Assert.IsNotNull(m);
        }


        [TestMethod]
        public void TestDeck()
        {
            DeckImporter importer = new DeckImporter(TestConstants.DECKPATH) ;
            Decklist d =  importer.Load("o'neil.o8d");

            Assert.IsTrue(d.team.Count == 4);

        }

        [TestMethod]
        public void TestMethodGameWithDecks()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(library);
            // StargateGameMock.InitPlayersWithMock(stargateGame);

            DeckImporter importer = new DeckImporter(TestConstants.DECKPATH);
            Decklist d = importer.Load("o'neil.o8d");

            stargateGame.InitPlayersWithDeck(d, d);


             //  StargateResult StargateResult = stargateGame.CardService.PlayMission(stargateGame.player1);
             //  Assert.AreEqual(StargateResult.actionResult, ActionResult.Success);




             GameState gs = stargateGame.GameState;
            stargateGame.GameState.InitGame(1);

            //  gs.ProcessEvent(new SelectCardEvent() { Sender = gs.player2, cardModel =  new List<CardModel>() { gs.CardRepository.Cards[0] } });


            Debug.WriteLine("end");

        }



        [TestMethod]
        public void TestMethod1()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(library) ;
            StargateGameMock.InitPlayersWithMock(stargateGame);



            //  StargateResult StargateResult = stargateGame.CardService.PlayMission(stargateGame.player1);
            //  Assert.AreEqual(StargateResult.actionResult, ActionResult.Success);




            GameState gs = stargateGame.GameState;  
            stargateGame.GameState.InitGame(1);
            
          //  gs.ProcessEvent(new SelectCardEvent() { Sender = gs.player2, cardModel =  new List<CardModel>() { gs.CardRepository.Cards[0] } });


            Debug.WriteLine("end");

        }



        [TestMethod]
        public void TestMethod2()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(library);
            StargateGameMock.InitPlayersWithMock(stargateGame);



            //  StargateResult StargateResult = stargateGame.CardService.PlayMission(stargateGame.player1);
            //  Assert.AreEqual(StargateResult.actionResult, ActionResult.Success);




            GameState gs = stargateGame.GameState;
            stargateGame.GameState.InitGame(1);


            //PrintStackRec((StargatePhase)gs.GameStack);


            gs.ProcessEvent(new SelectCardEvent() { Sender = gs.player2, cardModel = new List<CardModel>() { gs.CardRepository.Cards[1] } });
            gs.ProcessEvent(new AssignCharEvent() { Sender = gs.player1, cardModel =  gs.CardRepository.Cards[0]  });

            gs.ProcessEvent(new PassEvent() { Sender = gs.player2 });
            gs.ProcessEvent(new PassEvent() { Sender = gs.player1 });


            gs.ProcessEvent(new SelectCardEvent() { Sender = gs.player1, cardModel = new List<CardModel>() { gs.CardRepository.Cards[0] } });




            //gs.CheckQuestVictory();

            // both player pass
            // gs.ProcessEvent(new PassEvent() { Sender = gs.player1 });
            // gs.ProcessEvent(new PassEvent() { Sender = gs.player2 });



            // gs.ProcessEvent(new ContinueQuestEvent() { Sender = gs.player1, response=  });




            //gs.ProcessEvent(new PassEvent() { Sender = gs.player1 });
            //gs.ProcessEvent(new PassEvent() { Sender = gs.player2 });




            Debug.WriteLine("");

        }


        [TestMethod]
        public void TestGetCardIdFromModel()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(library);
            stargateGame.GameState.player1.id = 1;
            stargateGame.GameState.player2.id = 2;
            StargateGameMock.InitPlayersWithMock(stargateGame);



            StargateEvent sce = new SelectCardEvent() { SenderId = 1, CardModelId = new List<int> { 0 } };
            sce.Hydrate(stargateGame);


            Debug.WriteLine(sce);

        }

        [TestMethod]
        public void TestQuestResolution()
        {
            Library library = new Library(TestConstants.SETPATH);
            StargateGame stargateGame = new StargateGame(library);
            StargateGameMock.InitPlayersWithMock(stargateGame);


            stargateGame.GameState.CurrentPlayer = stargateGame.GameState.GetEnemyPlayer();
            QuestResolution qr  = new QuestResolution(stargateGame.GameState);


            try
            {
                qr.Play();

            }
            catch (Exception e )
            {

            }


            try
            {
                //ContinueQuestEventResponse cqer = new PassEvent() { re };
                qr.Play(  new ContinueQuestEvent { Sender = stargateGame.GameState.CurrentPlayer, response = ContinueQuestEventResponse.YES });

            }
            catch (Exception e)
            {

            }




        }



        private void PrintStackRec(StatePhase p)
        {
            Debug.WriteLine(p);

            if(p.actions.Count > 0)
            {

                foreach(KeyValuePair<int,StateAction> action in p.actions)
                {
                    PrintStackRec((StatePhase)action.Value);
                    
                }

            }
            
        }


    }
}
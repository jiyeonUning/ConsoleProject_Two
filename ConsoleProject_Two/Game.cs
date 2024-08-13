using ConsoleProject_Two.Endings;
using ConsoleProject_Two.Iventory;
using ConsoleProject_Two.Scenes;
using ConsoleProject_Two.Scenes_Outside;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleProject_Two
{
    public class Game
    {
        private bool isRunning;
        public Scene[] prevScene; // 인벤토리 이동 전 이전 화면 저장용

        private Scene[] scenes;
        private SceneEnding[] endingScenes;

        private Scene curScene;
        public SceneEnding curEndingScene;

        public Scene CurScene { get { return curScene; } }
        public SceneEnding CurEndingScene { get { return curEndingScene; } }


        public void Run()
        {
            Start();
            while (isRunning)
            {
                Render();
                Input();
                Update();
            }
            End();
        }

        private void Render()
        {
            curScene.Render();
        }

        private void Input()
        {
            curScene.Input();
        }

        private void Update()
        {
            curScene.Update();
        }

        //=============================

        private void Start()
        {
            isRunning = true;
            scenes = new Scene[(int)SceneType.Size];
            endingScenes = new SceneEnding[(int)EndingType.eSize];

            // < 장면(Scene) 나열 >
            //시작 화면
            scenes[(int)SceneType.타이틀화면] = new Title(this);

            //집
            scenes[(int)SceneType.내방_시작] = new MyRoomFrist(this);
            scenes[(int)SceneType.아래층1] = new UnderYes(this);
            scenes[(int)SceneType.아래층2] = new UnderNo(this);
            scenes[(int)SceneType.책상] = new Table(this);
            scenes[(int)SceneType.획득재봉가위] = new GetScissors(this);
            scenes[(int)SceneType.획득재봉키트] = new GetSew(this);
            scenes[(int)SceneType.동의함] = new Agree(this);

            //바깥
            scenes[(int)SceneType.바깥] = new Outside(this);

            //시스템화면
            curScene = scenes[(int)SceneType.타이틀화면];
            scenes[(int)SceneType.인벤토리] = new Inventory(this); 

            //엔딩장면
            endingScenes[(int)EndingType.불효녀] = new NotDutifulDaughter(this);  // 씬을 나눠서 출력하고 싶은데 어떻게 하면 좋을까요
            endingScenes[(int)EndingType.미식가] = new Gourmet(this);

            curScene.Enter();
            curEndingScene.Enter();
        }

        public void Over()
        {
            isRunning = false;
        }

        private void End()
        {
            curScene.Exit();
        }

        //===================================================

        public void ChangeScene(SceneType sceneType)
        {
            curScene.Exit();
            curScene = scenes[(int)sceneType];
            curScene.Enter();
        }

        public void ChangeEndingScene(EndingType endingType)
        {
            curEndingScene.Exit();
            curEndingScene = endingScenes[(int)endingType];
            curEndingScene.Enter();
        }

        // =====================================================

        // 인벤토리 이전 화면 저장
        public void InvenIn()
        {
            prevScene = scenes;
            Console.Clear();
            Console.WriteLine("가지고 있는 물건을 확인합니다...");
            Thread.Sleep(1000);
        }
        // 인벤토리 이전 화면으로 이동
        public void InvenOut() // 현재 나가는 거 구현 안됨
        {
            Console.Clear();
            Console.WriteLine("물건을 정리합니다...");
            Thread.Sleep(1000);
            scenes = prevScene;
        }
    }
    //==========================================================

    public abstract class Scene
    {
        protected Game game;

        public Scene(Game game)
        {
            this.game = game;
        }

        public abstract void Enter();
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Exit();
    }
    public abstract class SceneEnding
    {
        protected Game game;

        public SceneEnding(Game game)
        {
            this.game = game;
        }

        public abstract void Enter();
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Exit();
    }

    public enum SceneType
    {
        타이틀화면, 인벤토리,
        내방_시작, 아래층1, 아래층2,
        책상, 획득재봉가위, 획득재봉키트, 동의함,
        바깥,

        Size
    }

    public enum ItemType { 재봉키트, 재봉가위, iSize }
    public enum EndingType { 불효녀, 미식가, eSize }

}

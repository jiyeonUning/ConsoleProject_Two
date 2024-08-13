using ConsoleProject_Two.Iventory;
using ConsoleProject_Two.Scenes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleProject_Two
{
    public class Game
    {
        private bool isRunning;
        public ItemType scene; // 현재 위치 저장용
        public ItemType prevScene; // 인벤토리 이동 전 이전 화면 저장용

        private Scene[] scenes;
        private SceneItem[] itemScenes;
        private SceneEnding[] endingScenes;

        private Scene curScene;
        private SceneItem curItemScene;
        private SceneEnding curEndingScene;

        public Scene CurScene { get { return curScene; } }
        public SceneItem CurItemScene { get { return curItemScene; } }
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
            // 장면(Scene) 나열
            //시작 화면
            scenes[(int)SceneType.타이틀화면] = new Title(this);
            //시스템화면
            itemScenes[(int)ItemType.인벤토리] = new Inventory(this);
            //아이템
            itemScenes[(int)ItemType.재봉가위] = ;
            itemScenes[(int)ItemType.재봉키트] = ;

            //집
            scenes[(int)SceneType.내방_시작] = new Title(this);
            scenes[(int)SceneType.아래층1] = new Title(this);
            scenes[(int)SceneType.아래층2] = new Title(this);

            endingScenes[(int)EndingType.불효녀] = ;

            scenes[(int)SceneType.책상] = new Title(this);
            scenes[(int)SceneType.동의함] = new Title(this);

            endingScenes[(int)EndingType.미식가] = ;

            curScene.Enter();
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

        public void ChangeItemScene(ItemType itemType)
        {
            curItemScene.Exit();
            curItemScene = itemScenes[(int)itemType];
            curItemScene.Enter();
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
            
            Console.Clear();
            Console.WriteLine("가지고 있는 물건을 확인합니다...");
            Thread.Sleep(1000);
            prevScene = scene;
            scene = ItemType.인벤토리;
        }
        // 인벤토리 이전 화면으로 이동
        public void InvenOut()
        {
            Console.Clear();
            Console.WriteLine("물건을 정리합니다...");
            Thread.Sleep(1000);
            scene = prevScene;
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
    public abstract class SceneItem
    {
        protected Game game;
        public string itemName;

        public SceneItem(Game game)
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
        타이틀화면,
        내방_시작, 아래층1, 아래층2,
        책상,동의함,
        바깥
    }

    public enum ItemType { 인벤토리, 재봉가위, 재봉키트 }
    public enum EndingType { 불효녀, 미식가 }

}


namespace Jasarsoft.ModManager.TotalWar.Rome
{
    /************************************\  
     *  Error Message       -show_err;
     *  Disable Movie       -nm;
     *  Disable Video       -sw;
     *  Disable Audio       -na;
     *  Window Mode         -ne;
     *  Enable Editor       -enable_editor;
     *  Movie Camera        -movie_cam;
     *  AI Control          -ai;
     *  Multirun Game       -multirun;
     *  Generate Sprites    -sprite_script; 
    \*************************************/

    class OptionDefault
    {
        private string[] title;
        private string[] param;
        private bool[] state;

        public OptionDefault()
        {
            this.title = new string[10];
            this.param = new string[10];
            this.state = new bool[10];

            this.title[0] = "Show Error Message";
            this.param[0] = "show_err";
            this.state[0] = true;

            this.title[1] = "Disable Intro Movie";
            this.param[1] = "nm";
            this.state[1] = false;

            this.title[2] = "Disable All Video";
            this.param[2] = "sw";
            this.state[2] = false;

            this.title[3] = "Disable All Audio";
            this.param[3] = "na";
            this.state[3] = false;

            this.title[4] = "Enable Window Mode";
            this.param[4] = "ne";
            this.state[4] = false;

            this.title[5] = "Enable Battle Editor";
            this.param[5] = "enable_editor";
            this.state[5] = false;

            this.title[6] = "Enable Movie Camera";
            this.param[6] = "movie_cam";
            this.state[6] = false;

            this.title[7] = "AI Control Factions";
            this.param[7] = "ai";
            this.state[7] = false;

            this.title[8] = "Multirun Instance Game";
            this.param[8] = "multirun";
            this.state[8] = false;

            this.title[9] = "Generate Sprite Script";
            this.param[9] = "sprite_script";
            this.state[9] = false;
        }

        public string[] Title
        {
            get { return this.title; }
        }

        public string[] Param
        {
            get { return this.param; }
        }

        public bool[] State
        {
            get { return this.state; }
        }
    }
}

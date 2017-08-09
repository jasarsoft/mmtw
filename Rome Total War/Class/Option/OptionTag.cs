
namespace Jasarsoft.ModManager.TotalWar.Rome
{
    class OptionTag
    {
        private readonly string name;
        private readonly string info;
        private readonly string param;
        private readonly string state;

        public OptionTag()
        {
            this.name = "name";
            this.info = "info";
            this.param = "param";
            this.state = "state";
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Info
        {
            get { return this.info; }
        }

        public string Param
        {
            get { return this.param; }
        }

        public string State
        {
            get { return this.state; }
        }
    }
}

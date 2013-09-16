namespace SharpStorm.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class TopologyBuilder
    {
        private IDictionary<string, ISpout> spouts = new Dictionary<string, ISpout>();
        private IDictionary<string, IBolt> bolts = new Dictionary<string, IBolt>();

        public void SetSpout(string name, ISpout spout)
        {
            this.spouts[name] = spout;
        }

        public ISpout GetSpout(string name)
        {
            if (this.spouts.ContainsKey(name))
                return this.spouts[name];

            return null;
        }

        public void SetBolt(string name, IBolt bolt)
        {
            this.bolts[name] = bolt;
        }

        public IBolt GetBolt(string name)
        {
            if (this.bolts.ContainsKey(name))
                return this.bolts[name];

            return null;
        }
    }
}

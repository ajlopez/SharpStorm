namespace SharpStorm.Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SharpStorm.Core.Tests.Bolts;
    using SharpStorm.Core.Tests.Spouts;

    [TestClass]
    public class TopologyBuilderTests
    {
        [TestMethod]
        public void GetUnknownSpoutAsNull()
        {
            TopologyBuilder builder = new TopologyBuilder();

            Assert.IsNull(builder.GetSpout("Unkown"));
        }

        [TestMethod]
        public void SetAndGetSimpleSpout()
        {
            TopologyBuilder builder = new TopologyBuilder();
            ISpout spout = new SimpleSpout(); 

            builder.SetSpout("Simple", spout);

            var result = builder.GetSpout("Simple");

            Assert.IsNotNull(result);
            Assert.AreSame(spout, result);
        }

        [TestMethod]
        public void GetUnknownBoltAsNull()
        {
            TopologyBuilder builder = new TopologyBuilder();

            Assert.IsNull(builder.GetBolt("Unkown"));
        }

        [TestMethod]
        public void SetAndGetSimpleBolt()
        {
            TopologyBuilder builder = new TopologyBuilder();
            IBolt bolt = new SimpleBolt();

            builder.SetBolt("Simple", bolt);

            var result = builder.GetBolt("Simple");

            Assert.IsNotNull(result);
            Assert.AreSame(bolt, result);
        }
    }
}

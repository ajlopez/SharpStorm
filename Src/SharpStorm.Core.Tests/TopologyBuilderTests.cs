namespace SharpStorm.Core.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}

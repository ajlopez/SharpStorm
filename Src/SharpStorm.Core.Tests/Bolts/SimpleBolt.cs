namespace SharpStorm.Core.Tests.Bolts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SimpleBolt : IBolt
    {
        public void Execute(IContext context, object tuple)
        {
            throw new NotImplementedException();
        }
    }
}

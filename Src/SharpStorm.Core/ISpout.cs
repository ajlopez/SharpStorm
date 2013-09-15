namespace SharpStorm.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ISpout
    {
        void NextTuple(IContext context);
    }
}

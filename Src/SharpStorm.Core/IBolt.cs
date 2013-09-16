namespace SharpStorm.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IBolt
    {
        void Execute(IContext context, object tuple);
    }
}

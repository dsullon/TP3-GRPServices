using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GRP.Logic;

namespace GRP.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetData()
        {
            var data = TipoArticuloBL.Listar();
        }
    }
}

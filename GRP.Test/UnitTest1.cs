using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GRP.Data;
using GRP.Data.UnitOfWork;

namespace GRP.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetData()
        {
            using (var uow = new UnitOfWork())
            {
                var tipo = uow.ArticuloRepository.GetAll();
            }
        }
    }
}

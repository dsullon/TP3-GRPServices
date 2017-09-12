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
            int[] array = { 1, 2, 3, 4, 5 };

            using (var uow = new UnitOfWork())
            {
                var tipo = uow.ProductoRepository.GetPerItem(array);
            }
        }
    }
}

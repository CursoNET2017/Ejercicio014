using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio014;
using Microsoft.Practices.Unity;

namespace Ejercicio014Test
{
    [TestClass]
    public class VentaControlerIntegracionTest
    {
        private IVentaControler ventaControler;

        [TestInitialize]
        public void Inicialize()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IVentaRepository, VentaRepository>();
            unityContainer.RegisterType<IVentaService, VentaService>();
            unityContainer.RegisterType<IVentaConverter, VentaConverter>();
            unityContainer.RegisterType<IVentaControler, VentaControler>();

            ventaControler = unityContainer.Resolve<IVentaControler>();

        }







        [TestMethod]
        public void CreateMethod()
        {
            VentaDTO ventaDTO = new VentaDTO();
            ventaControler.Create(ventaDTO);
        }
    }
}

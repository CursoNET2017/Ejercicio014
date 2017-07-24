using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio014;
using Microsoft.Practices.Unity;

namespace Ejercicio014Test
{
    [TestClass]
    public class EntradaControlerIntegracionTest
    {
        private IEntradaControler entradaControler;
        EntradaDTO entradaDTO;

        [TestInitialize]
        public void Inicialize()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEntradaRepository, EntradaRepository>();
            unityContainer.RegisterType<IEntradaService, EntradaService>();
            unityContainer.RegisterType<IEntradaConverter, EntradaConverter>();
            unityContainer.RegisterType<IEntradaControler, EntradaControler>();

            entradaControler = unityContainer.Resolve<IEntradaControler>();
            entradaDTO = new EntradaDTO();
        }


        [TestMethod]
        public void CreateMethod()
        {            
            entradaControler.Create(entradaDTO);
        }

        [TestMethod]
        public void DeleteMethod()
        {
            entradaControler.Delete(entradaDTO.Id);
        }

        [TestMethod]
        public void ReadMethod()
        {
            entradaControler.Read(entradaDTO.Id);
        }

        [TestMethod]
        public void ReadAllMethod()
        {
            entradaControler.ReadAll();
        }

        [TestMethod]
        public void UpdateMethod()
        {
            entradaControler.Update(entradaDTO);
        }












    }
}

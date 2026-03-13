using CountryGuide.Controllers;
using CountryGuide.Models;
using CountryGuide.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CountryGuideTest
{
    public class PaisControllerTest
    {

        [Test]
        public void Index_Get_Deve_Retornar_View()
        {
            var mockService = new Mock<PaisService>(null, null);
            var controller = new PaisController(mockService.Object);

            var result = controller.Index();
            Assert.IsInstanceOf<ViewResult>(result);
        }

        [Test]
        public virtual async Task<Pais?> Index_Post_Deve_Retornar_View_Com_Pais()
        {
            var mockService = new Mock<PaisService>(null, null);

            var pais = new Pais
            {
                Nome = new NomePais 
                {
                    NomeConhecido = "Italy"
                }

            };

            mockService
                .Setup(setup => setup.ObterPaisAsync("italy"))
                .ReturnsAsync(pais);

            var controller = new PaisController(mockService.Object);

            var result = await controller.Index("italy");

            var viewResult = result as ViewResult;

            Assert.IsNotNull(viewResult);
            Assert.That(viewResult.Model, Is.EqualTo(pais));
        }

        [Test]
        public virtual async Task<Pais?> Index_Post_Deve_Retornar_View_Com_Null_Quando_Pais_Nao_Existe()
        {
            var mockService = new Mock<PaisService>(null, null);

            mockService
                .Setup(setup => setup.ObterPaisAsync("xyz"))
                .ReturnsAsync((Pais?)null);

            var controller = new PaisController(mockService.Object);

            var result = await controller.Index("xyz");

            var viewResult = result as ViewResult;

            Assert.IsNotNull(viewResult);
            Assert.IsNull(viewResult.Model);
        }

    }
}
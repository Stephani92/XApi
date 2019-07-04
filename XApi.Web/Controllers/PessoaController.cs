using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using XApi.Api.Controllers.Base;
using XApi.Domain.Arguments.Pessoa;
using XApi.Domain.Interfaces.Services;
using XApi.Infra.Transactions;



namespace XApi.Api.Controllers
{
    [RoutePrefix("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly IServPessoa _servicePessoa;


        public PessoaController(IServPessoa servicePessoa, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _servicePessoa = servicePessoa;
        }

        [Route("adicionar")]
        [HttpPost]
        public async Task<HttpResponseMessage> Adicionar(AddPessoaRequest request)
        {
            try
            {
                var response = _servicePessoa.AddPessoa(request);

                return await ResponseAsync(response, _servicePessoa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }

        [Route("Listar")]
        [HttpGet]
        public async Task<HttpResponseMessage> Listar()
        {
            try
            {
                var response = _servicePessoa.ListaPessoas();

                return await ResponseAsync(response, _servicePessoa);
            }
            catch (Exception ex)
            {
                return await ResponseExceptionAsync(ex);
            }
        }


    }
}
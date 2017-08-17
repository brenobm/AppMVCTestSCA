using CEB.SCA.Services.Spec.Services;
using CEB.SCA.WebControls.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVCTestSCA.Controllers.Base
{
    public class CustomController : SCAController
    {
        public override IAutenticacaoService GetAutenticacaoService()
        {
            return serviceLocator.GetService<IAutenticacaoService>("ceb.servicos/AutenticacaoService", SCAApplicationContext.ObterParametrosServico(), "userinfo");
        }
    }
}
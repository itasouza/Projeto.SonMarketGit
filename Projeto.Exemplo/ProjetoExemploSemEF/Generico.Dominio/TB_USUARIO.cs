using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico.Dominio
{
   public  class TB_USUARIO
    {
        [Display(Name = "Controle do Usuário:")]
        public int IDUSUARIO { get; set; }

        [Display(Name = "Nome do Usuário:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NOME { get; set; }


        [Display(Name = "Login:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string LOGIN { get; set; }


        [Display(Name = "Senha:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string SENHA { get; set; }

        [Display(Name = "Administrador:")]
        public bool ADMINISTRADOR { get; set; }

    }
}

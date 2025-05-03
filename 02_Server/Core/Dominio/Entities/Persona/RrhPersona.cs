using Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities.Persona
{
    [Table("rrh_persona", Schema = "public")]
    public partial class RrhPersona : AuditableBaseEntity
    {
        [Key]
        public int IdrrhPersona { get; set; }
        public string NombreApellido { get; set; }
        public string Ci { get; set; }
        public string Exp { get; set; }
        public string Celular { get; set; }


        public DateTime? FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public string Domicilio { get; set; }
        public string Residencia { get; set; }
        public string InicioContrato { get; set; }
        public string Correo { get; set; }



        /*id*/
        public string IdgenUnidad { get; set; }
        public string IdgenCategoria { get; set; }
        public string IdgenClase { get; set; }
        public string IdgenNivelsalarial { get; set; }
        public string IdgenPuestodenominacion { get; set; }
        public string IdgenSexo { get; set; }
        public string IdgenProfesion { get; set; }
        public DateTime IdgengrupoTrabajo { get; set; }
    }

}

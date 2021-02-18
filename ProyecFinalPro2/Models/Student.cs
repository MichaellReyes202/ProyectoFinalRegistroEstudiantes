using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecFinalPro2.Models
{
    [Serializable]
     public class Student 
    {
        public string[] nacional = new string[] { "Nacional", "Extranjero" };
        public string[] departamento = new string[] { "Boaco", "Carazo", "Chinandega", "Chontales", "Costa Caribe Norte", "Costa Caribe Sur", "Estelí", "Granada", "Jinotega", "León", "Madriz", "Managua", "Masaya", "Matagalpa", "Nueva Segovia", "Río San Juan", "Rivas" };
        public string[] Boaco = new string[] { "Boaco", "Camoapa", "San José de los Remates", "San Lorenzo", "Santa Lucía", "Teustepe" };
        public string[] Carazo = new string[] { "Diriamba", "Dolores", "El Rosario", "Jinotepe", "La Conquista", "La Paz de Oriente", "San Marcos", "Santa Tereza" };
        public string[] Chinandega = new string[] { "Chichigalpa", "Chinandega", "Cinco Pino", "Corinto", "El Realejo", "El Viejo", "Posoltega", "Puerto Morazán", "San Francisco del Norte", "San Pedro del Norte", "Somotillo", "Villanueva" };
        public string[] Chontales = new string[] { "Acoyapa", "Comalapa", "Cuapa", "El Coral", "Juigalpa", "La Libertad", "San Pedro de Lóvago", "Santo Domingo", "Santo Tomás", "Villa Sandino" };
        public string[] CostaN = new string[] { "Bonanza", "Mulukukú", "Prinzapolka", "Puerto Cabezas", "Rosita", "Siuna", "Waslala", "Waspán" };
        public string[] CostaS = new string[] { "Bluefields", "Desembocadura de Río Grande", "El Ayote", "El Rama", "El Tortuguero", "Islas del Maiz", "Kukra Hill", "La Cruz de Río Grande", "Laguna de Perlas", "Muelle de los Bueyes", "Nueva Guinea", "Paiwas" };
        public string[] Estéli = new string[] { "Condega", "Estelí", "La Trinidad", "Pueblo Nuevo", "San Juan de Limay", "San Nicolás" };
        public string[] Granada = new string[] { "Diriá", "Diriomo", "Granada", "Nandaime" };
        public string[] Jinotega = new string[] { "El Cuá", "Jinotega", "La Concordia", "San José de Bocay", "San Rafael del Norte", "San Sebastián de Yali", "Santa Maria de Pantasma", "Wiwilí de Jinotega" };
        public string[] Leon = new string[] { "Achuapa", "El Jicaral", "El Sauce", "La Paz Centro", "Larreynaga", "León", "Nagarote", "Quezalguaque", "Santa Rosa del Peñón", "Telica" };
        public string[] Madriz = new string[] { "Las Sabanas", "Palacaguina", "San José de Cusmapa", "San Juan de Río Coco", "San Lucas", "Somoto", "Telpaneca", "Totogalpa", "Yalaguina" };
        public string[] Managua = new string[] { "Ciudad Sandino", "El Crucero", "Managua", "Mateare", "San Francisco Libre", "San Rafael del Sur", "Ticuantepe", "Tipitapa", "Villa El Carmen" };
        public string[] Masaya = new string[] { "Catarina", "La Concepción", "Masatepe", "Masaya", "Nandasmo", "Nindirí", "Niquinohomo", "San Juan de Oriente", "Tisma" };
        public string[] Matagalpa = new string[] { "Ciudad Darío", "El Tuma-La Dalia", "Esquipulas", "Matagalpa", "Matiguás", "Muy Muy", "Rancho Grande", "Río Blanco", "San Dionisio", "San Isidro", "San Ramón", "Sébaco", "Terrabona" };
        public string[] NuevaS = new string[] { "Ciudad Antigua", "Dipilto", "El Jícaro", "Jalapa", "Macuelizo", "Mozonte", "Murra", "Ocotal", "Quilalí", "San Fernando", "Santa María", "Wiwilí" };
        public string[] RSanJ = new string[] { "El Almendro", "El Castillo", "Morrito", "San Carlos", "San Juan del Norte", "San Miguelito" };
        public string[] Rivas = new string[] { "Altagracia", "Belén", "Buenos Aires", "Cárdenas", "Moyogalpa", "Potosí", "Rivas", "San Jorge", "San Juan del Sur", "Tola" };
        public string GrupBox { get; set; }
        public int ComboTurno { get; set; }
        public string NyABox { get; set; }
        public string CarnetBox { get; set; }
        public bool? SolteroRadio { get; set; }
        public bool? CasadoRadio { get; set; }
        public bool? MRadio { get; set; }
        public bool? FRadio { get; set; }
        public string LyFBox { get; set; }
        public string AgeBox { get; set; }
        public int ComboNacional { get; set; }
        public int ComboDepart { get; set; }
        public int ComboMuni { get; set; }
        public string DirectBox { get; set; }
        public string TelfBox { get; set; }
        public string CelBox { get; set; }
        public string EmailBox { get; set; }
        public string CentroBox { get; set; }
        public bool? EstaRadio{ get; set; }
        public bool? PrivRadio { get; set; }
        public bool? SubvRadio { get; set; }
        public bool? OrdiRadio{ get; set; }
        public bool? BecRadio { get; set; }
        public bool? TrabRadio { get; set; }
        public bool? TrabajaSRadio { get; set; }
        public bool? TrabajaNRadio { get; set; }
        public bool? NIngrRadio { get; set; }
        public bool? ReingreRadio { get; set; }
        public bool? TrasIntRadio { get; set; }
        public bool? TrasExteRadio { get; set; }
        public bool? ContCarrRadio { get; set; }
        public bool? SegCarrRadio { get; set; }

        
        public static string Title() 
        {
            return "HOJA DE MATRICULA CURSO ELECTIVO "+Year()+"\nPROGRAMA DE MODALIDAD ESPECIAL (PROMECYS)";
        }

        public static string Day() 
        {
            return DateTime.Now.ToString("dd");
        }

        public static string Moth()
        {
            return DateTime.Now.ToString("MM");
        }

        public static string Year()
        {
            return DateTime.Now.ToString("yyyy");
        }


    }
}

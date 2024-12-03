namespace promedio1.Models
{
    public class Alumno
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double Nota1 { get; set; } //accesorios de la propiedad nota 1
        public double Nota2 { get; set; } //accesorios de la propiedad nota 
        public double Promedio
        {
            get
            {
                return (Nota1 + Nota2) / 2;
            }

        }
    }
}

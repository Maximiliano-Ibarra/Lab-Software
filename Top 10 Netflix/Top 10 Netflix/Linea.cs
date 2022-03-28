using System;

namespace Top_10_Netflix
{
    internal class Linea
    {
        public int id_pelicula { get; set; }
        public long id_usuario { get; set; }
        public int puntaje { get; set; }
        public DateTime fecha_puntaje { get; set; }
        public int contPuntajes { get; set; }

        public Linea()
        {
            id_pelicula = 0;
            id_usuario = 0;
            puntaje = 0;
            fecha_puntaje = new DateTime(2000 - 01 - 01);
            contPuntajes = 0;
        }

        public Linea(int idPeli, long idUser, int punt, DateTime fecha)
        {
            id_pelicula = idPeli;
            id_usuario = idUser;
            puntaje = punt;
            fecha_puntaje = fecha;
            contPuntajes = 0;
        }
    }
}
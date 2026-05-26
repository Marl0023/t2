using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class ArbolBBP
    {
        private NodoP Primero { get; set; }
        public void Agregar(int codigo, string nombre, int antiguedad)
        {
            Primero = InsertarRecursivo(Primero,codigo, nombre, antiguedad);
        }
        private NodoP InsertarRecursivo(NodoP r, int codigo, string nombre, int antiguedad)
        {
            if (r == null)
            {
                Empleado Emp = new Empleado(codigo,nombre,antiguedad);
                return new NodoP(Emp);
            }
            else if (antiguedad < r.Valor.Antiguedad)
            {
                r.Izqu = InsertarRecursivo(r.Izqu, codigo, nombre, antiguedad);
            }
            else if (antiguedad > r.Valor.Antiguedad)
            {
                r.Dere = InsertarRecursivo(r.Dere, codigo, nombre, antiguedad);
            }
            return r;
        }
        public void MuestraInCodigo()
        {
            MuestraInCodigo(Primero);
        }
        private void MuestraInCodigo(NodoP r)
        {
            if (r != null)
            {

                MuestraInCodigo(r.Izqu);
                Console.Write(r.Valor.Codigo + " ");
                MuestraInCodigo(r.Dere);
            }
        }
        public void MuestraPosAntiguedad()
        {
            MuestraPosAntiguedad(Primero);
        }
        private void MuestraPosAntiguedad(NodoP r)
        {
            if (r != null)
            {
                MuestraPosAntiguedad(r.Izqu);
                MuestraPosAntiguedad(r.Dere);
                Console.Write(r.Valor.Antiguedad + " ");
            }
        }
        public void MayoresA(int antiguedad) {
            if (Primero == null)
                Console.WriteLine("El árbol está vacío.");
            else {
                Buscarrec(Primero, antiguedad);
                
            }
            
        }
        private void Buscarrec(NodoP reco, int valor) {
            if (reco == null) {
                return;
            }
            if (reco.Valor.Antiguedad > valor)
            {
                Buscarrec(reco.Izqu, valor);
                Console.WriteLine(reco.Valor.Nombre + " ");
                Buscarrec(reco.Dere, valor);
            }
            else {
                Buscarrec(reco.Dere, valor);
            }
        }
        public void Penultimo() {
            if (Primero == null || (Primero.Izqu == null && Primero.Dere == null)){
                Console.WriteLine("No existe");
                return;
            }
            NodoP actual = Primero;
            NodoP padre = null;
            while (actual.Dere != null) {
                padre = actual;
                actual = actual.Dere;
            }
            if (actual.Izqu != null) {
                NodoP temp = actual.Izqu;
                while (temp.Dere != null) {
                    temp = temp.Dere;
                }
                Console.WriteLine(temp.ToString();
            }
            else {
                Console.WriteLine(padre.ToString();
            }
                            

        }
    }
}

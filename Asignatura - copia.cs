using System;


namespace EDexamenT6a8
{


    /*Clase que representa la gestíon de las notas para una asignatura.
     * Se puede(métodos): Introducir la asignatura
     *                    Registrar las notas de prácticas y examen para cada evaluación.
     *                    Calcular las notas por cada trimestre.
     *                    Calcular la nota final de curso.
     * Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
     */

    //<Summary> Clase Asignatura
    class Asignatura
    {
        public Asignatura //<Remark> he aplicado sangría por que se podía
        (
            string CodAsignatura, string NombAsignatura, double NotaTrimestre1, double NotaTrimestre2, double NotaTrimestre3, double NotaFinal)
        {
            this.CodAsignatura = CodAsignatura; //<Returns> Codigo de la asignatura.
            this.NombAsignatura = NombAsignatura; //<Returns> Nombre de la asignatura.
                                                  // <Returns> Nota de los trimestres (1, 2   y 3) y nota final.
            this.NotaTrimestre1 = NotaTrimestre1;
            this.NotaTrimestre2 = NotaTrimestre2;
            this.NotaTrimestre3 = NotaTrimestre3;
            this.NotaFinal = NotaFinal;
        }



        public string CodAsignatura;
        public string NombAsignatura;
        public double NotaTrimestre1;
        public double NotaTrimestre2;
        public double NotaTrimestre3;
        public double NotaFinal;



        public void IntroducirMateria(string Cod_de_Asignatura, string Nombre_de_Asignatura)
        {
            this.CodAsignatura = Cod_de_Asignatura; this.NombAsignatura = Nombre_de_Asignatura;

        }

        public void IntroducirlasNotas(double notadelExamen1, double notadelExamen2, double notadelExamen3, double notadelasPracticas1, double notadelasPracticas2, double notadelasPracticas3)
        {

            {
                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine("Trimestre evaluado 1, 2 ó 3: ");
                    var Trimestre = Console.ReadLine();




                    switch (Trimestre)
                    {
                        case "1":
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen1 = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "2":
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen2 = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "3":
                            Console.WriteLine("Nota de las prácticas: ");
                            notadelasPracticas3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Nota del examen: ");
                            notadelExamen3 = Convert.ToDouble(Console.ReadLine());
                            break;
                    }


                }

            }
        }









        public double calculodelaNota1(double notadelExamen1, double notadelasPracticas1)

        {
            this.NotaTrimestre1 = (notadelExamen1 * 0.8) + (notadelasPracticas1) * 0.2; //<Param> La nota está comupuesta  por 20 % de la nota de prácticas y 80 % de la nota del examen. 
            return this.NotaTrimestre1;
        }

        public double calculodelaNota2(double notadelExamen2, double notadelasPracticas2)

        {
            this.NotaTrimestre2 = (notadelExamen2 * 0.8) + (notadelasPracticas2) * 0.2;
            return this.NotaTrimestre2;
        }

        public double calculodelaNota3(double notadelExamen3, double notadelasPracticas3)

        {
            this.NotaTrimestre3 = (notadelExamen3 * 0.8) + (notadelasPracticas3) * 0.2;
            return this.NotaTrimestre3;
        }

        public double Calculodelamedia()
        {
            this.NotaFinal = (this.NotaTrimestre1 + this.NotaTrimestre2 + this.NotaTrimestre3) / 3; //<Param> Nota final del curso
            return this.NotaFinal;
        }

    } //<Remark>he puesto espacios para que sea más cómodo leerlo
    //<Summary> ejemplo de una asignatura
    class ejemplodeunaAsignatura
    {

       

        static void main()
        {



            asignatura mi_asignatura_ejemplo = new asignatura("0521385", "Entornos  de Desarrollo");



        }
    }

    /*TODO
        <Summary>Clase Asignatura
             <Returns> Código de la asignatura
             <Returns> Nombre de la asignatura.
             <Returns> Nota de los trimestres (1, 2   y 3) y nota final.
                 <Param> La nota está comupuesta  por 20 % de la nota de prácticas y 80 % de la nota del examen.
                 <Param> Nota final del curso
             
        <Summary>Ejemplo de una Asignatura
       */
}
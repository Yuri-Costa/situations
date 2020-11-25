using System;

namespace gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tipl do combustivel? G - Gasolina ou A - Álcool ");
            string tipo = Console.ReadLine();

            //-----------------------------------------------------------------------------

            Console.WriteLine("digite a quantidade de litros que voce quer abastecer");
            float litros = float.Parse(Console.ReadLine());
            float precoalcool = 4.8f;
            float precogasolina = 5.2f;
            float resultado ;
            float valoraserpago;

            //-------------------------------------------------------------------------------


            switch(tipo.ToLower()){

                case "A":
                resultado = valoraserpago(litros,precoalcool,0.0f,0.06f);
                Console.WriteLine("object valor a ser pago é de : {resultado}");
                break;

                case "G":
                resultado = valoraserpago(litros,precogasolina,0.0f,0.06f);
                Console.WriteLine("object valor a ser pago é de : {resultado}");
                break;


            }//fim do switch

            //-------------------------------------------------------------------------------------

                float valoraserpago (float litros, float preco, float preco1, float preco2){
                    float porcentualdesconto;

                    if(litros <= 20){
                        porcentualdesconto= preco1;
                    }else{porcentualdesconto=preco2;}

                    float totaldesconto = (litros * preco) * porcentualdesconto;
                    float valorbruto = (litros * preco);
                    float valorapagar = valorbruto - totaldesconto;
                    return valorapagar;

                }
        }
    }
}

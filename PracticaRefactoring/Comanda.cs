using System.Collections.Generic;

namespace PracticaRefactoring
{
    class Comanda
    {
        private readonly double IVA = 0.21;
        public double CalcularDespesa(List<Detall> detallList, string client)
        {
            double despesa = 0.0;
            double importBrut = CalcularBrut(detallList);

            if (client.EndsWith("B") && !(importBrut > 500)) despesa = 5.0;

            if (client.EndsWith("C"))
            {
                despesa = importBrut * 0.03;
                if (despesa > 10) despesa = 10;
            }

            return despesa;
        }

        public double CalcularDescompte(List<Detall> detallList, string client)
        {
            double descompte;


            Dictionary<char, double> descomptesMap = new Dictionary<char, double>
            {
                {'A', 0.05 },
                {'B', 0.03 },
                {'C', 0.01 },
            };

            double importBrut = CalcularBrut(detallList);

            char lastLetter = client[client.Length - 1];

            descompte = GetDescompte(importBrut, descomptesMap[lastLetter]);

            return descompte;
        }

        public double CalcularIVA(List<Detall> detallList)
        {
            double importBrut = CalcularBrut(detallList);

            double iva = GetIva(importBrut);

            return iva;
        }

        public double CalcularBrut(List<Detall> detallList)
        {
            double importBrut = 0.0;

            foreach (Detall detall in detallList) importBrut += detall.Quantitat * detall.Preu;

            return importBrut;
        }

        public double CalcularTotal(List<Detall> detallList, string client)
        {
            double importBrut = CalcularBrut(detallList);

            double iva = GetIva(importBrut);

            double despesa = CalcularDespesa(detallList, client);

            double descompte = CalcularDescompte(detallList, client);

            double importNet = importBrut + iva + despesa - descompte;

            return importNet;
        }

        public double GetDescompte(double import, double dto)
        {
            return import * dto;
        }
        public double GetIva(double importBrut)
        {
            return importBrut * IVA;
        }
    }
}
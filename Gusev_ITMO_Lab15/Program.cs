using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface ISeries
    {
        // служебные поля

        // автосвойства
        int InitialValue { set; get; } // Начальное значение прогрессии

        int CurentValue { set; get; }  // Текущее значение прогрессии

        // методы
        void setStart(int x); //  устанавливает начальное значение
        int getNext();        //  возвращает следующее число ряда
        void reset();         //  выполняет сброс к начальному значению
    }

    class ArithProgression : ISeries
    {
        private int initialValue; // первый член арифметической прогрессии
        public int InitialValue
        {
            get
            {
                return initialValue;
            }
            set
            {
                initialValue = value;
            }
        }

        private int curentValue; // текущий член арифметической прогрессии 
        public int CurentValue
        {
            get
            {
                return curentValue;
            }
            set
            {
                curentValue = value;
            }
        }

        private int stepArithProgression; // шаг арифметической прогрессии
        public int StepArithProgression
        {
            get
            {
                return stepArithProgression;
            }
            set
            {
                stepArithProgression = value;
            }
        }

        public void setStart(int x)
        {
            this.InitialValue = x;
           // throw new NotImplementedException();
        }

        public int getNext()
        {
            this.CurentValue = this.CurentValue + this.StepArithProgression;
            return this.CurentValue;
        }

        public void reset()
        {
            this.CurentValue = this.initialValue;
        }

        public void setStep(int y)
        {
            this.StepArithProgression = y;
        }
    }

    class GeomProgression : ISeries
    {
        private int initialValue;
        public int InitialValue
        {
            get
            {
                return initialValue;
            }
            set
            {
                initialValue = value;
            }
        }

        private int curentValue;
        public int CurentValue
        {
            get
            {
                return curentValue;
            }
            set
            {
                curentValue = value;
            }
        }

        private int koeffGeomProgression; // шаг геометрической прогрессии
        public int KoeffGeomProgression
        {
            get
            {
                return KoeffGeomProgression;
            }
            set
            {
                KoeffGeomProgression = value;
            }
        }

        public void setStart(int x)
        {
            this.InitialValue = x;
        }

        public int getNext()
        {
            this.CurentValue = this.CurentValue * this.KoeffGeomProgression;
            return this.CurentValue;
        }

        public void reset()
        {
            this.CurentValue = this.InitialValue;
        }
    }


   
}

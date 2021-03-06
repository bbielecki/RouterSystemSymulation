using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{

    class Stream                // klasa strumienia wejsciowego / charakteryzuje sie ona priorytetem oraz przypisanym do niego buforem w routerze/
    {
        private string name;
        private int priority;
        public int bufor;
        private string lengthDistribution; // nazwa rozkładu z którego losowana jest dlugosc paczki
        private string waitingDistribution; //nazwa rozkładu z którego losowana jest wartość odstepu miedzy przychodzacymi paczkami
        private int numberOflengthDistribution;//ilosc rozkladow
        private int numberOfWaitingDistribution;

        public Stream(string m_name, string m_lengthDistribution, string m_waitingDistribution, int m_priority, int m_bufor)
        {
            bufor = m_bufor;
            name = m_name;
            priority = m_priority;
            lengthDistribution = m_lengthDistribution;
            waitingDistribution = m_waitingDistribution;
        }
        public string GetName() { return name; }
        public int GetNumberOflengthDistribution() { return numberOflengthDistribution; }
        public int GetNumberOfWaitingDistribution() { return numberOfWaitingDistribution; }
        public string GetNameOflengthDistribution() { return lengthDistribution; }
        public string GetNameOfWaitingDistribution() { return waitingDistribution; }
        public int GetPriority() { return priority; }

        public void SetNumberOflengthDistribution(int m_numberOflengthDistribution) { numberOflengthDistribution = m_numberOflengthDistribution; }
        public void SetNumberOdWaitingDistribution(int m_nemberOfWaitingDistribution) { numberOfWaitingDistribution = m_nemberOfWaitingDistribution; }
    }

}




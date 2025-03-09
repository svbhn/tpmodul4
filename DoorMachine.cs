using tpmodul4_103022300081;

namespace tpmodul4_103022300081
{
    public class DoorMachine
    {
        public enum State
        {
            Terkunci,
            Terbuka
        }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah dalam keadaan terbuka");
            }
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah dalam keadaan terkunci");
            }
        }

        public State GetCurrentState()
        {
            return currentState;
        }
    }
}
namespace filosofos
{
    public partial class Form1 : Form
    {
        public bool palillo1 = true, palillo2 = true, palillo3 = true, palillo4 = true, palillo5 = true;
        public static int filosofo = 5;
        public int palillos = filosofo; 
        public Semaphore sem = new Semaphore(2,3);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hilos con parametros
            Thread hbobsponja = new Thread(new ThreadStart(() => parametros(1)));
            hbobsponja.Start();
            Thread hbobsponja2 = new Thread(new ThreadStart(() => parametros(2)));
            hbobsponja2.Start();
            Thread hbobsponja3 = new Thread(new ThreadStart(() => parametros(3)));
            hbobsponja3.Start();
            Thread hbobsponja4 = new Thread(new ThreadStart(() => parametros(4)));
            hbobsponja4.Start();
            Thread hbobsponja5 = new Thread(new ThreadStart(() => parametros(5)));
            hbobsponja5.Start();
            /*for (int i = 1; i < 5; i++)
            {
                
                //hilos de sponja
                Thread bobsponja1 = new Thread(sponja1);
                Thread bobsponja2 = new Thread(sponja2);
                Thread bobsponja3 = new Thread(sponja3);
                Thread bobsponja4 = new Thread(sponja4);
                Thread bobsponja5 = new Thread(sponja5);
                //Inicializacion de hilos
                bobsponja1.Start();
                bobsponja2.Start();
                bobsponja3.Start();
                bobsponja4.Start();
                bobsponja5.Start();
            }*/

        }
        public void parametros(int filosofo)
        {
            //Palillos inicializacion
            int Pizq = filosofo +1;
            int Pd = filosofo;
            //si es filosofo 5 se modifica palillo izquierdo para 1 
            if (filosofo == 5)
            {
                Pizq = 1;
            }
            //inicializar semaforo
            sem.WaitOne();
            if(Pizq == 1 && Pd == 2)
            {
                //ocupar palillos
                palillo1 = false;
                palillo2 = false;
                //modificar imagenes
                Invoke((Delegate)new Action(() => {
                    //visibilidad de las imagenes
                    bobsponja1.Visible = false;
                    bobtoronja1.Visible = true;
                    //visibilidad de los palillos
                    palo1.Visible = false;
                    palo2.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
            //en otro caso modificar visibilidad de bob sponja
            Invoke((Delegate)new Action(() => {
                //visibilidad del avatar
                bobsponja1.Visible = true;
                bobtoronja1.Visible = false;
                //visibilidad de los palos
                palo1.Visible = true;
                palo2.Visible = true;
            }));
            //soltar palillos
            palillo2 = true;
            palillo3 = true;
        }
            if(Pizq == 2 && Pd == 3)
            {
                //palillos ocupados
                palillo2 = false;
                palillo3 = false;
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad de avatares
                    bobsponja2.Visible = false;
                    bobtoronja2.Visible = true;
                    //visibilidad de palos
                    palo2.Visible = false;
                    palo3.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad del avatar 
                    bobsponja2.Visible = true;
                    bobtoronja2.Visible = false;
                    //visibilidad de palillos
                    palo2.Visible = true;
                    palo3.Visible = true;
                }));
                //Dejar palillos libres
                palillo2 = true;
                palillo3 = true;
            }
            if(Pizq == 3 && Pd == 4)
            {
                //Palillos ocupados
                palillo3 = false;
                palillo4 = false;
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad avatar
                    bobsponja3.Visible = false;
                    bobtoronja3.Visible = true;
                    //visibilidad de palillos
                    palo3.Visible = false;
                    palo4.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
                //Visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja3.Visible = true;
                    bobtoronja3.Visible = false;
                    //visibilidad de cubiertos
                    palo3.Visible = true;
                    palo4.Visible = true;
                }));
                //desocupar palillos
                palillo3 = true;
                palillo4 = true;
            }
            if (Pizq == 4 && Pd == 5)
            {
                //palillos ocupados
                palillo4 = false;
                palillo5 = false;
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja4.Visible = false;
                    bobtoronja4.Visible = true;
                    //visibilidad de palillos
                    palo4.Visible = false;
                    palo5.Visible = false;
                }));
                //Dormir hilo
                Thread.Sleep(3000);
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja4.Visible = true;
                    bobtoronja4.Visible = false;
                    //visibilidad de palillos
                    palo4.Visible = true;
                    palo5.Visible = true;
                }));
                //desocupar palillos
                palillo4 = true;
                palillo5 = true;
            }
            if (Pizq == 5 && Pd == 1)
            {
                //palillos ocupados
                palillo5 = false;
                palillo1 = false;
                //visibilidad 
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad avatar
                    bobsponja5.Visible = false;
                    bobtoronja5.Visible = true;
                    //visibilidad de los palillos
                    palo5.Visible = false;
                    palo1.Visible = false;
                }));
                //dormir hilo 3 seg
                Thread.Sleep(3000);
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja5.Visible = true;
                    bobtoronja5.Visible = false;
                    //visibilidad de palillos
                    palo5.Visible = true;
                    palo1.Visible = true;
                }));
                //desocupar palillos
                palillo5 = true;
                palillo1 = true;
            }
            if (palillo1 == true && palillo2 == true)
            {
                //ocupar palillos
                palillo1 = false;
                palillo2 = false;
                //modificar imagenes
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de las imagenes
                    bobsponja1.Visible = false;
                    bobtoronja1.Visible = true;
                    //visibilidad de los palillos
                    palo1.Visible = false;
                    palo2.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);

                //en otro caso modificar visibilidad de bob sponja
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad del avatar
                    bobsponja1.Visible = true;
                    bobtoronja1.Visible = false;
                    //visibilidad de los palos
                    palo1.Visible = true;
                    palo2.Visible = true;
                }));
                //soltar palillos
                palillo2 = true;
                palillo3 = true;
            }
            //reiniciar el semaforo
            if (palillo2 == true && palillo3 == true)
            {
                //palillos ocupados
                palillo2 = false;
                palillo3 = false;
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad de avatares
                    bobsponja2.Visible = false;
                    bobtoronja2.Visible = true;
                    //visibilidad de palos
                    palo2.Visible = false;
                    palo3.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad del avatar 
                    bobsponja2.Visible = true;
                    bobtoronja2.Visible = false;
                    //visibilidad de palillos
                    palo2.Visible = true;
                    palo3.Visible = true;
                }));
                //Dejar palillos libres
                palillo2 = true;
                palillo3 = true;
        }
            if (palillo2 == true && palillo3 == true)
            {
                //palillos ocupados
                palillo2 = false;
                palillo3 = false;
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad de avatares
                    bobsponja2.Visible = false;
                    bobtoronja2.Visible = true;
                    //visibilidad de palos
                    palo2.Visible = false;
                    palo3.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
            //visibilidad
            Invoke((Delegate)new Action(() => {
                //visibilidad del avatar 
                bobsponja2.Visible = true;
                bobtoronja2.Visible = false;
                //visibilidad de palillos
                palo2.Visible = true;
                palo3.Visible = true;
            }));
            //Dejar palillos libres
            palillo2 = true;
            palillo3 = true;
            }
            if (palillo3 == true && palillo4 == true)
            {
                //ocupar palillos
                palillo3 = false;
                palillo4 = false;
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja3.Visible = false;
                    bobtoronja3.Visible = true;
                    //visibilidad de palillos
                    palo3.Visible = false;
                    palo4.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja3.Visible = true;
                    bobtoronja3.Visible = false;
                    //visibilidad de palillos
                    palo3.Visible = true;
                    palo4.Visible = true;
                }));
                //desocupar palillos
                palillo3 = true;
                palillo4 = true;
            }
            if (palillo4 == true && palillo5 == true)
            {
                //ocupar palillos
                palillo4 = false;
                palillo5 = false;
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja4.Visible = false;
                    bobtoronja4.Visible = true;
                    //visibilidad de palillos
                    palo4.Visible = false;
                    palo5.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja4.Visible = true;
                    bobtoronja4.Visible = false;
                    //visibilidad de palillos
                    palo4.Visible = true;
                    palo5.Visible = true;
                }));
                //desocupar palillos
                palillo4 = true;
                palillo5 = true;
            }
            if (palillo5 == true && palillo1 == true)
            {
                //ocupar palillos
                palillo5 = false;
                palillo1 = false;
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja5.Visible = false;
                    bobtoronja5.Visible = true;
                    //visibilidad de palillos
                    palo5.Visible = false;
                    palo1.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
                //visibilidad
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de avatar
                    bobsponja5.Visible = true;
                    bobtoronja5.Visible = false;
                    //visibilidad de palillos
                    palo5.Visible = true;
                    palo1.Visible = true;
                }));
                //desocupar palillos
                palillo5 = true;
                palillo1 = true;
            }
            //reiniciar semaforo
            sem.Release();
        }
        public void sponja1()
        {
            //Semaforo inicializado
            sem.WaitOne();
            //Verificar palillos
            if (palillo1 == true && palillo2 == true)
            {
                //ocupar palillos
                palillo1 = false;
                palillo2 = false;
                //modificar imagenes
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad de las imagenes
                    bobsponja1.Visible = false;
                    bobtoronja1.Visible = true;
                    //visibilidad de los palillos
                    palo1.Visible = false;
                    palo2.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
                //en otro caso modificar visibilidad de bob sponja
                Invoke((Delegate)new Action(() =>
                {
                    //visibilidad del avatar
                    bobsponja1.Visible = true;
                    bobtoronja1.Visible = false;
                    //visibilidad de los palos
                    palo1.Visible = true;
                    palo2.Visible = true;
                }));
                //soltar palillos
                palillo2 = true;
                palillo3 = true;
            }
            //reiniciar el semaforo
            sem.Release();
        }
        


        public void sponja2()
        {
            //semaforo inicializado
            sem.WaitOne();
            //comparar si estan disponibles palillos
            if (palillo2 == true && palillo3 == true)
            {
                //palillos ocupados
                palillo2 = false;
                palillo3 = false;
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad de avatares
                    bobsponja2.Visible = false;
                    bobtoronja2.Visible = true;
                    //visibilidad de palos
                    palo2.Visible = false;
                    palo3.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
            }
            //visibilidad
            Invoke((Delegate)new Action(() => {
                //visibilidad del avatar 
                bobsponja2.Visible = true;
                bobtoronja2.Visible = false;
                //visibilidad de palillos
                palo2.Visible = true;
                palo3.Visible = true;
            }));
            //Dejar palillos libres
            palillo2 = true;
            palillo3 = true;
            //Reiniciar semaforo
            sem.Release();
        }
        public void sponja3()
        {
            //Inicializar el semaforo
            sem.WaitOne();
            //Verificar si los palillos estan libres
            if (palillo3 == true && palillo4 == true)
            {
                //ocupar palillos
                palillo3 = false;
                palillo4 = false;
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad de avatar
                    bobsponja3.Visible = false;
                    bobtoronja3.Visible = true;
                    //visibilidad de palillos
                    palo3.Visible = false;
                    palo4.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
            }
            //visibilidad
            Invoke((Delegate)new Action(() => {
                //visibilida de avatar
                bobsponja3.Visible = true;
                bobtoronja3.Visible = false;
                //visibilidad de palillos
                palo3.Visible = true;
                palo4.Visible = true;
            }));
            //desocupar palillos
            palillo3 = true;
            palillo4 = true;
            //reiniciar semaforo
            sem.Release();
        }
        public void sponja4()
        {
            //inicializar semaforo
            sem.WaitOne();
            if (palillo4 == true && palillo5 == true)
            {
                //ocupados palillos
                palillo4 = false;
                palillo5 = false;
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad de avatar
                    bobsponja4.Visible = false;
                    bobtoronja4.Visible = true;
                    //visibilidad de palillos
                    palo4.Visible = false;
                    palo5.Visible = false;
                }));
                //dormir hilos
                Thread.Sleep(3000);
            }
            //visibilidad
            Invoke((Delegate)new Action(() => {
                //visibilidad de avatar 
                bobsponja4.Visible = true;
                bobtoronja4.Visible = false;
                //visibilidad de palillos
                palo4.Visible = true;
                palo5.Visible = true;
            }));
            //desocupar palillos
            palillo4 = true;
            palillo5 = true;
            //reiniciar semaforo
            sem.Release();
        }
        public void sponja5()
        {
            //inicializar semaforo
            sem.WaitOne();
            if (palillo5 == true && palillo1 == true)
            {
                //palillos ocupados
                palillo5 = false;
                palillo1 = false;
                //visibilidad
                Invoke((Delegate)new Action(() => {
                    //visibilidad de avatar
                    bobsponja5.Visible = false;
                    bobtoronja5.Visible = true;
                    //visibilida de palillos
                    palo5.Visible = false;
                    palo1.Visible = false;
                }));
                //dormir hilo
                Thread.Sleep(3000);
            }
            //visibilidad
            Invoke((Delegate)new Action(() => {
                //visibilidad de avatar
                bobsponja5.Visible = true;
                bobtoronja5.Visible = false;
                //visibilidad de palillos
                palo5.Visible = true;
                palo1.Visible = true;
            }));
            //desocupar palillos
            palillo5 = true;
            palillo1 = true;
            //reinciar semaforo
            sem.Release();
        }
    }
}
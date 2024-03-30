namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {

            // create a tank (and assign a driver)
            Tank tank = new Tank();
            tank.AssignDriver("Frank");
            // create a robot
            Adapter robot = new Adapter(new Robot());
            robot.AssignDriver("Mark");
            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(robot);
            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                Console.WriteLine($"Driver of attacker: {attacker.Driver}");
                attacker.DriveForward();
                attacker.UseWeapon();
            }
        }

        
    }
}
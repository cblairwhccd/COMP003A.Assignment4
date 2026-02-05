namespace COMP003A.Assignment4;

class Program
{
    private const int MAX_STEPS = 4; /* Maximum no. of steps in routine */

    static void Main()
    {
        /* No. steps of routine completed */
        int step = 0;

        /* Show menu options */
        Console.WriteLine("1. Start/Continue Routine");
        Console.WriteLine("2. View Progress");
        Console.WriteLine("3. Exit");

        /* Using a loop, repeat menu code until the user decides to exit */
        bool running = true; /* This variable controls whether to keep running the menu */
        while (running)
        {
            /* Prompt for selection */
            Console.Write("\nEnter choice: ");
            switch (Console.ReadLine())
            {
                case "1": /* Do routine step */
                    /* Enforce safety limit (do not perform another step) */
                    if (step >= MAX_STEPS)
                    {
                        Console.WriteLine("Safety limit reached. Routine stopped.");
                    }
                    else /* Perform step */
                    {
                        step++;
                        Console.WriteLine($"Routine step {step} completed.");
                    }
                    break;
                case "2": /* View progress */
                    break;
                case "3": /* Exit */
                    /* Cannot use `break` to leave the loop here, so use a boolean variable instead */
                    running = false; /* Next evaluation of loop condition will become false, thereby leaving the loop */
                    break;
            }
        }
    }
}
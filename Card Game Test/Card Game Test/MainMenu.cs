using System;
using System.Drawing;
using System.Windows.Forms;

namespace Card_Game_Test
{
    // We inherit directly from Form to turn this class into our window
    public class MainMenu : Form
    {
        // --- 1. GAME CONTROLS (UI Elements) ---
        private TextBox desc;
        private Button myButton;

        // --- 2. MAIN APPLICATION ENTRY POINT ---
        [STAThread] // Required by Windows to run UI applications smoothly
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // This instantiates our class and opens it as a window
            Application.Run(new MainMenu());
        }

        // --- 3. CONSTRUCTOR (Your Custom Setup Instead of InitializeComponent) ---
        public MainMenu()
        {
            // Set up the Main Form Window dimensions
            this.ClientSize = new Size(784, 561);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Card Game - A Scratch Port - Original By nomishark";

            // Initialize the Lore Text Box
            this.desc = new TextBox();
            this.desc.BackColor = SystemColors.Window;
            this.desc.BorderStyle = BorderStyle.None;
            this.desc.Location = new Point(425, 25);
            this.desc.Multiline = true;
            this.desc.ReadOnly = true;
            this.desc.Size = new Size(325, 500);
            this.desc.WordWrap = true;
            this.desc.Text = "Lore(spoilers) one day you were sitting on a bench when you fall in to the black area. Where a god will call you. Where you have to roll some cards and buy upgrades to escape the abyss or you could stay and become the best card roller in the abyss. End of lore. Start of spoilers if you stay in the abyss when the phone ask you the phone asks at 1,000,000 over all points you get a prestige like system with more upgrade for you that is why it takes so long to get there. End of spoilers.\r\n\n\r\nThe phone rings at 100 and 1,000 and 10,000 and 100,000 and 1,000,000, and 1,000,000,000 over all points (overall points are the amount of points you gotten if you didn’t spent points)\r\n\r\n\r\n\r\n\r\nThis was originally a scratch game, and I am bringing it to C# and actual applications. Possibly will bring nomishark onto this project as primary.";

            // Initialize your Button (Properly Instantiated!)
            this.myButton = new Button();
            this.myButton.Text = "Play Game";
            this.myButton.BackColor = Color.LightBlue;
            this.myButton.ForeColor = Color.Black;       
            this.myButton.Font = new Font("Arial", 12, FontStyle.Bold);
            this.myButton.Location = new Point(100, 50); 
            this.myButton.Size = new Size(120, 40);      
            
            // Attach your custom click routine
            this.myButton.Click += MyButton_Click;

            // Render both controls to the visual screen
            this.Controls.Add(this.desc);
            this.Controls.Add(this.myButton);
        }

        // --- 4. GAME ACTIONS ---
        private void MyButton_Click(object sender, EventArgs e)
        {
        	
        }
    }
}

using System;

using System.Drawing;
using System.Windows.Forms;

namespace Life
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // declaring the variables to create an array for the cells, we set the number of cloums and rows
        // also how big each cell will be
        static int rows = 10;
        static int col = 10;   
        
        // grid cells format 
        int Width = 40;         
        int Height = 40;

        static int deep = 20;

        // this th array that has all the necessary variables for the cells 
        string[,,] cellGrid = new string[col, rows, deep]; 

        // this panel where the cells will be created 
        Panel cells = new Panel(); 

        // craeting a function to put the cells we created on to the form2
        private void Form2_Load_1(object sender, EventArgs e)
        {
            this.Controls.Add(cells);
            // locations of the starting cells
            cells.Location = new Point(0, 0);

            // setting the cell size dimentions 
            cells.Size = new Size(Width * col, Height * rows);

            // this for loop will create the cells and the set varibales 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button cell = new Button();
                    cellGrid[j, i, 0] = "D";// cells will begin dead 

                    // the cells location is updated 
                    cell.Location = new Point((j * Width), (i * Height));

                    // the cell size is set and creating the cell
                    cell.Size = new Size(Width, Height);
                    // adding the interfce color an style 
                    cell.Click += button_Click;
                    cell.BackColor = Color.Blue; 
                    // adding th cell information to the panel 
                    cells.Controls.Add(cell); 
                }
            }
        }
        
        // this function will enable the user to click one of the cells and either make it alive or dead 
        private void button_Click(object sender, EventArgs e)
        {
            Button thisButton = ((Button)sender);

            // this will find the indexes at which the cells x and y postions are 
            int xpostion = thisButton.Location.X / Width;
            int ypostion = thisButton.Location.Y / Height;

            // this if and else statement determines if the color is Blue then the cell is dead
            if (thisButton.BackColor == Color.Blue) 
            {
                // when is blue and we click on the sell the cell will turn Red indicating that is living
                thisButton.BackColor = Color.Red; 
                cellGrid[xpostion, ypostion, 0] = "A"; 

            }
            // if the cell is red then when we click it it will turn blue again to indicate is dead 
            else 
            {
                thisButton.BackColor = Color.Blue; 
                cellGrid[xpostion, ypostion, 0] = "D"; 
            }
        }

        // this cell will determine if a cell keeps leaving or a new cell becomes alive 
        void Friends()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int friends = 0;

                    // chackin if the cell has enough friends if not it dies 
                    for (int x = i - 1; x < i + 2; x++)
                    {
                        for (int z = j - 1; z < j + 2; z++)
                        {

                            // this try and catch error make sure the cell is alvide and not dead 
                            try
                            {
                                if (x == i && z == j) { friends += 0; }
                                else if (cellGrid[z, x, 0] == "A") { friends += 1; }
                            }

                            catch  { friends += 0; }
                        }
                    }
                    // seding the cell infromation to the string 
                    cellGrid[j, i, 1] = friends.ToString();
                }
            }
        }
        // Here it will generate the next generation of cells after the first generaton
        public void NextGeration()
        {
            // here foreach is use to transverse every item in the array 
            foreach (Control cell in cells.Controls)
            {
                // the next gereation index locaiton will be updated 
                int xpostion = cell.Left / Width;
                int ypostion = cell.Top / Height;
                // converting the friens locaitons to an integer 
                int friends = Convert.ToInt32(cellGrid[xpostion, ypostion, 1]);

                // if the cell has less then 2 or more than 3 it remains dead 
                if (friends  < 2 | friends > 3)
                {
                    cellGrid[xpostion, ypostion, 0] = "D";
                    cell.BackColor = Color.Blue;

                }
                // however if the cell has exaclty 3 friends then it becomes alive 
                else if (friends == 3)
                {
                    cellGrid[xpostion, ypostion, 0] = "A";
                    cell.BackColor = Color.Red;
                }
            }
        }

        // this function will do the same each generaiton that the usrer desires 
        public void next_life()
        {
            Friends();
            NextGeration();
        }

        // this fucntion is compose of a timer that if click the generation button it will present a generation at each click stoping and stating again 
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            next_life();
        }
        
        // this fucntion is the reset fucntion, upon cliking the rest the cells will start again, all dead like in the start
        private void ResetBttn_Click_1(object sender, EventArgs e)
        {
            // for loops , all the rows and colums will go back to beind dead 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    // the cells are all dead 
                    cellGrid[j, i, 0] = "D"; 

                }
            }
            // the next geration will go and continue 
            next_life(); 
        }

        // You can pass generations manually by pressing Next Gen Button
        private void NextGenBttn_Click_1(object sender, EventArgs e)
        {
            next_life();
        }

    }
}
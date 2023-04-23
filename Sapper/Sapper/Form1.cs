using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapper
{
    public partial class Form1 : Form
    {
        int width = 10;
        int height = 10;
        int offset = 30;
        int bombPercent = 10;
        bool FirstClick=true;
        FieldButton[,] field;
        int cellsOpened=0;
        int bombs=0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = GetRandomColor();
            StartPosition = FormStartPosition.CenterScreen;
            field = new FieldButton[width, height];
            GenerateField();
        }
        public void GenerateField()
        {
            Random random = new Random();
            for(int y=0; y<height; y++)
            {
                for(int x=0; x<width; x++)
                {
                    FieldButton newButton = new FieldButton();
                    newButton.Location = new Point(x*offset, y*offset); 
                    newButton.Size = new Size(offset, offset);
                    newButton.isClickable = true;
                    if(random.Next(0,100) <= bombPercent)
                    {
                        newButton.isBomb = true;
                        bombs++;
                    }
                    newButton.xCoord = x;
                    newButton.yCoord = y;
                    Controls.Add(newButton);
                    newButton.MouseUp += new MouseEventHandler(FieldButtonClick);
                    field[x, y] = newButton;
                }
            }
        }

        void FieldButtonClick(object sender,MouseEventArgs e)
        {
            FieldButton clickedButton = (FieldButton)sender;
            if(e.Button == MouseButtons.Left && clickedButton.isClickable)
            {
                if (clickedButton.isBomb)
                {
                    if (FirstClick)
                    {
                        clickedButton.isBomb = false;
                        FirstClick = false;
                        bombs--;
                        OpenRegion(clickedButton.xCoord, clickedButton.yCoord, clickedButton);
                    }
                    else
                    {
                        Explode();
                    }

                }
                else
                {
                    EmptyFieldButtonClick(clickedButton);
                }

                FirstClick = false;
            }
            if(e.Button == MouseButtons.Right)
            {
                clickedButton.isClickable = !clickedButton.isClickable;
                if (!clickedButton.isClickable)
                {

                }
                else
                {
                    clickedButton.Text = "";

                }
            }
            CheckWin();
        }

        void Explode()
        {
            foreach(FieldButton button in field)
            {
                if (button.isBomb)
                {
                    button.Text = "*";
                }
            }
            MessageBox.Show($"You lost! Your score is {score}. Try again.");
            Application.Restart();
        }

        void EmptyFieldButtonClick(FieldButton clickedButton)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if(field[x, y] == clickedButton)
                    {
                        OpenRegion(x, y, clickedButton);
                    }
                }
            }
        }

        void OpenRegion(int xCoord, int yCoord, FieldButton clickedButton)
        {
            Queue<FieldButton> queue = new Queue<FieldButton>();
            queue.Enqueue(clickedButton);
            clickedButton.wasAdded = true;
            while (queue.Count > 0)
            {
                FieldButton currentCell = queue.Dequeue();
                OpenCell(currentCell.xCoord, currentCell.yCoord, currentCell);
                cellsOpened++;
                if (CountBombsAround(currentCell.xCoord, currentCell.yCoord) == 0)
                {
                    for (int y = currentCell.yCoord - 1; y <= currentCell.yCoord + 1; y++)
                    {

                        for (int x = currentCell.xCoord - 1; x <= currentCell.xCoord + 1; x++)
                        {
                            if (x == currentCell.xCoord && y == currentCell.yCoord)
                            {
                                continue;
                            }
                            if (x >= 0 && x < width && y < height && y >= 0)
                            {
                                if (!field[x, y].wasAdded)
                                {
                                    queue.Enqueue(field[x,y]);
                                    field[x, y].wasAdded = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        void OpenCell(int x, int y, FieldButton clickedButton)
        {
            int bombsAround = CountBombsAround(x, y);
            if (bombsAround == 0)
            {

            }
            else
            {
                clickedButton.Text = "" + bombsAround;
                score += bombsAround;
            }
            clickedButton.Enabled = false;
        }

        int CountBombsAround(int xCoord, int yCoord) 
        {
            int bombsAround=0;
            for (int x = xCoord - 1; x <= xCoord + 1; x++)
            {

                for (int y = yCoord - 1; y <= yCoord + 1; y++)
                {
                    if (x >= 0 && x < width && y < height && y >= 0)
                    {
                        if (field[x, y].isBomb==true)  
                        {
                           bombsAround++;
                        }
                    }
                }
            }
           return bombsAround;
        }

        void CheckWin()
        {
            int cells = width * height;
            int emptyCells = cells - bombs;
            if (cellsOpened >= emptyCells)
                MessageBox.Show($"You win!!! Your score is {score}. Play again?");
        }

        private Color GetRandomColor()
        {
            Random rnd = new Random();
            return Color.FromArgb(rnd.Next(128,256), rnd.Next(128,256), rnd.Next(128,256));
        }

        public class FieldButton:Button
        {
            public bool isBomb;
            public bool isClickable;
            public bool wasAdded;
            public int xCoord;
            public int yCoord;
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 10;
            height = 18;
            GenerateField();
        }

        private void x100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 100;
            height = 100;
            GenerateField();

        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 10;
            height = 10;
            GenerateField();

        }

        private void x5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            width = 5;
            height = 5;
            GenerateField();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Max
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<List<char>> matrix = GetMatrix();
            List<char> complite_text = new List<char>();

            //if (matrix.Count > 1 && matrix[0].Count > 1) {
            if (uLR.Checked)
            {
                complite_text = LeftUpper(matrix, false);
            }
            else if (uLD.Checked)
            {
                complite_text = LeftUpper(matrix, true);
            }
            else if (uRL.Checked)
            {
                complite_text = RightUpper(matrix, true);
            }
            else if (uRD.Checked)
            {
                complite_text = RightUpper(matrix, false);
            }
            else if (bRL.Checked)
            {
                complite_text = RightBottom(matrix, false);
            }
            else if (bRU.Checked)
            {
                complite_text = RightBottom(matrix, true);
            }
            else if (bLR.Checked)
            {
                complite_text = LeftBottom(matrix, true);
            }
            else if (bLU.Checked)
            {
                complite_text = LeftBottom(matrix, false);
            }
            else
            {
                MessageBox.Show($"Нужно выбрать способ обхода!");
            }
            ThisText.Text = "";
            for (int i = 0; i < complite_text.Count; i++)
            {
                ThisText.Text += complite_text[i];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uLR.Checked = true;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="f"> true == Left to Down    
        /// false == Left to right</param>
        /// <returns></returns>
        private List<char> LeftUpper(List<List<char>> matrix, bool f)
        {           
            int rowMax = matrix.Count;
            int colMax = matrix[0].Count;

            int max = matrix.Count * matrix[0].Count;
            List<char> code = new List<char>();

            for (int i = 0; i < max; i++)
            {
                code.Add(' ');
            }

            int p = 0;
            int _col = -1;
            int _row = -1;

            int _colEven = -1;
            int counter = 0;

            for (int rows = 0; rows < rowMax; rows++)
            {
                if (rows > colMax -1)
                {
                    counter++;
                }
                for (int columns = 0; columns < rows + 1; columns++)
                {
                    if (rows > colMax - 1)
                    {

                        _col = f ? rows - columns - counter : columns;
                        _row = f ? columns + counter : rows - _col;

                        if ((rowMax % 2 == 0 && colMax % 2 != 0) || (rowMax % 2 != 0 && colMax % 2 == 0))
                        {
                            _colEven = f ? columns : rows - columns - counter;
                        }
                    }
                    else
                    {
                        _col = f ? rows - columns : columns;
                        _row = rows - _col;
                        if ((rowMax % 2 == 0 && colMax % 2 != 0) || (rowMax % 2 != 0 && colMax % 2 == 0))
                        {
                            _colEven = f ? columns : rows - columns;
                        }
                    }

                    if (columns > colMax - 1)
                    {
                        break;
                    }

                    code[p] = matrix[_row][_col];

                    if ((rowMax % 2 == 0 && colMax % 2 != 0 )|| (rowMax % 2 != 0 && colMax % 2 == 0))
                    {
                        code[max - p - 1] = matrix[rowMax + _colEven - rows - 1][colMax - _colEven - 1];
                    }
                    else
                    {
                        code[max - p - 1] = matrix[rowMax + _col - rows - 1][colMax - _col - 1];
                    }
                    p++;
                }
                f = !f;
            }

            return code;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="f"> true == Right to Up 
        /// false == Right to Left</param>
        /// <returns></returns>
        private List<char> RightBottom(List<List<char>> matrix, bool f)
        {
            List<List<char>> temp = new List<List<char>>();
            int maxRows = matrix.Count;
            int maxColumns = matrix[0].Count;

            for (int i = 0; i < maxRows; i++)
            {
                temp.Add(new List<char>());
                for (int j = 0; j < maxColumns; j++)
                {
                    temp[i].Add(matrix[maxRows - i - 1][maxColumns - j - 1]);
                }
            }
            return LeftUpper(temp, f);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="f"> true == Left to Right    
        /// false == Left to Up</param>
        /// <returns></returns>
        private List<char> LeftBottom(List<List<char>> matrix, bool f)
        {
            List<List<char>> temp = new List<List<char>>();
            int maxRows = matrix.Count;
            int maxColumns = matrix[0].Count;

            for (int j = 0; j < maxColumns; j++)
            {
                temp.Add(new List<char>());
                for (int i = maxRows - 1; i >= 0; i--)
                {
                    temp[j].Add(matrix[i][j]);
                }
            }
            return LeftUpper(temp, f);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="f"> true == Right to Left    
        /// false == Right to Down</param>
        /// <returns></returns>
        private List<char> RightUpper(List<List<char>> matrix, bool f)
        {
            List<List<char>> temp = new List<List<char>>();
            int maxRows = matrix.Count;
            int maxColumns = matrix[0].Count;

            for (int j = maxColumns - 1; j >= 0; j--)
            {
                temp.Add(new List<char>());
                for (int i = 0; i < maxRows; i++)
                {
                    temp[maxColumns - j - 1].Add(matrix[i][j]);
                }
            }
            return LeftUpper(temp, f);
        }

        //Это не работает...
        private void Button2_Click(object sender, EventArgs e)
        {
            List<List<char>> matrix = GetMatrix();
            List<char> complite_text = new List<char>();

            if (uLR.Checked)
            {
                complite_text = LeftUpperDecode(matrix, false);
            }
            else if (uLD.Checked)
            {
                complite_text = LeftUpperDecode(matrix, true);
            }
            else if (uRL.Checked)
            {
                complite_text = RightUpperDecode(matrix, true);
            }
            else if (uRD.Checked)
            {
                complite_text = RightUpperDecode(matrix, false);
            }
            else if (bRL.Checked)
            {
                complite_text = LeftUpper(matrix, false);
            }
            else if (bRU.Checked)
            {
                complite_text = LeftUpper(matrix, true);
            }
            else if (bLR.Checked)
            {
                complite_text = LeftUpper(matrix, true);
            }
            else if (bLU.Checked)
            {
                complite_text = LeftUpper(matrix, false);
            }
            else
            {
                MessageBox.Show($"Нужно выбрать способ обхода!");
            }

            ThisText.Text = "";
            for (int i = 0; i < complite_text.Count; i++)
            {
                ThisText.Text += complite_text[i];
            }
        }

        private List<char> LeftUpperDecode(List<List<char>> matrix, bool f)
        {
            List<char> code = new List<char>();

            int max = matrix.Count * matrix[0].Count;
            int rowMax = matrix.Count;
            int colMax = matrix[0].Count;


            for (int i = 0; i <rowMax; i++)
            {
                for (int j = 0; j < colMax; j++)
                {
                    code.Add(matrix[i][j]);
                }
            }

            int p = 0;
            int _col = -1;
            int _row = -1;

            int _colEven = -1;
            int counter = 0;

            for (int rows = 0; rows < rowMax; rows++)
            {
                if (rows > colMax - 1)
                {
                    counter++;
                }
                for (int columns = 0; columns < rows + 1; columns++)
                {
                    if (rows > colMax - 1)
                    {

                        _col = f ? rows - columns - counter : columns;
                        _row = f ? columns + counter : rows - _col;

                        if ((rowMax % 2 == 0 && colMax % 2 != 0) || (rowMax % 2 != 0 && colMax % 2 == 0))
                        {
                            _colEven = f ? columns : rows - columns - counter;
                        }
                    }
                    else
                    {
                        _col = f ? rows - columns : columns;
                        _row = rows - _col;
                        if ((rowMax % 2 == 0 && colMax % 2 != 0) || (rowMax % 2 != 0 && colMax % 2 == 0))
                        {
                            _colEven = f ? columns : rows - columns;
                        }
                    }

                    if (columns > colMax - 1)
                    {
                        break;
                    }

                    matrix[_row][_col] = code[p];

                    if ((rowMax % 2 == 0 && colMax % 2 != 0) || (rowMax % 2 != 0 && colMax % 2 == 0))
                    {
                         matrix[rowMax + _colEven - rows - 1][colMax - _colEven - 1] = code[max - p - 1] ;
                    }
                    else
                    {
                        matrix[rowMax + _col - rows - 1][colMax - _col - 1] = code[max - p - 1] ;
                    }
                    p++;
                }
                f = !f;
            }

            code.RemoveRange(0, max);
            for (int i = 0; i < rowMax; i++)
            {
                for (int j = 0; j < colMax; j++)
                {
                    code.Add(matrix[i][j]);
                }
            }

            return code;
        }

        private List<char> RightUpperDecode(List<List<char>> matrix, bool f)
        {
            List<List<char>> temp = new List<List<char>>();
            int maxRows = matrix.Count;
            int maxColumns = matrix[0].Count;

            for (int i = 0; i < maxRows; i++)
            {
                temp.Add(new List<char>());
                for (int j = 0; j < maxColumns; j++)
                {
                    temp[i].Add(matrix[maxRows - i - 1][maxColumns - j - 1]);
                }
            }
            return LeftUpperDecode(temp, f);
        }
        private List<List<char>> GetMatrix()
        {
            string text = ThisText.Text;


            int temp = text.Length;
            int a = 10000;
            int b = 1;
            int c = 0;

            do
            {
                b++;
                if (temp % b == 0)
                {
                    a = temp / b;
                    c = b;
                }
            } while (a > b);

            List<List<char>> matrix = new List<List<char>>();

            

            int k = 0;
            if (uLR.Checked || uLD.Checked || bRL.Checked || bRU.Checked)
            {
                for (int i = 0; i < c; i++)
                {
                    matrix.Add(new List<char>());
                    for (int j = 0; j < a; j++)
                    {
                        matrix[i].Add(text[k]);
                        k++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < a; i++)
                {
                    matrix.Add(new List<char>());
                    for (int j = 0; j < c; j++)
                    {
                        matrix[i].Add(text[k]);
                        k++;
                    }
                }
            }
            return matrix;
        }
    }
}
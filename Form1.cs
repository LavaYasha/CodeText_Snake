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
        private void Form1_Load(object sender, EventArgs e)
        {
            uLR.Checked = true;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            List<List<char>> matrix = GetMatrixCode();

            DebugText.Text = "";

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    DebugText.Text += $"{matrix[i][j]} ";
                }
                DebugText.Text += '\n';
            }
            DebugText.Text += "\n";

            List<char> complite_text = new List<char>();

            //if (matrix.Count > 1 && matrix[0].Count > 1) {
            if (uLR.Checked)
            {
                complite_text = LeftUpperCode(matrix, false);
            }
            else if (uLD.Checked)
            {
                complite_text = LeftUpperCode(matrix, true);
            }
            else if (uRL.Checked)
            {
                complite_text = RightUpperCode(matrix, true);
            }
            else if (uRD.Checked)
            {
                complite_text = RightUpperCode(matrix, false);
            }
            else if (bRL.Checked)
            {
                complite_text = RightBottomCode(matrix, false);
            }
            else if (bRU.Checked)
            {
                complite_text = RightBottomCode(matrix, true);
            }
            else if (bLR.Checked)
            {
                complite_text = LeftBottomCode(matrix, true);
            }
            else if (bLU.Checked)
            {
                complite_text = LeftBottomCode(matrix, false);
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

        
        private void Button2_Click(object sender, EventArgs e)
        {
            string text = ThisText.Text;
            List<char> charText = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                charText.Add(text[i]);
            }

            int maxRow = 0, maxColumn = 0;
            GetMatrixDeCode(out maxRow, out maxColumn);
            DebugText.Text = "";
            List<List<char>> complite_text = new List<List<char>>();


            if (uLR.Checked)
            {
                complite_text = LeftUpperDeCode(charText, false, maxRow, maxColumn);
            }
            else if (uLD.Checked)
            {
                complite_text = LeftUpperDeCode(charText, true, maxRow, maxColumn);
            }
            else if (uRL.Checked)
            {
                complite_text = RightUpperDeCode(charText, true, maxRow, maxColumn);
            }
            else if (uRD.Checked)
            {
                complite_text = RightUpperDeCode(charText, false, maxRow, maxColumn);
            }
            else if (bRL.Checked)
            {
                complite_text = RightBottomDeCode(charText, false, maxRow, maxColumn);
            }
            else if (bRU.Checked)
            {
                complite_text = RightBottomDeCode(charText, true, maxRow, maxColumn);
            }
            else if (bLR.Checked)
            {
                complite_text = LeftBottomDeCode(charText, true, maxRow, maxColumn);
            }
            else if (bLU.Checked)
            {
                complite_text = LeftBottomDeCode(charText, false, maxRow, maxColumn);
            }
            else
            {
                MessageBox.Show($"Нужно выбрать способ обхода!");
            }

            ThisText.Text = "";
            for (int i = 0; i < complite_text.Count; i++)
            {
                for (int j = 0; j < complite_text[i].Count; j++)
                {
                    ThisText.Text += complite_text[i][j];
                }
            }
        }

        #region Code
        /// <summary>
        ///
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="f"> true == Left to Down    
        /// false == Left to right</param>
        /// <returns></returns>
        private List<char> LeftUpperCode(List<List<char>> matrix, bool f)
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
                    if (columns > colMax - 1)
                    {
                        break;
                    }
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
        private List<char> RightBottomCode(List<List<char>> matrix, bool f)
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


            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < temp[i].Count; j++)
                {
                    DebugText.Text += $"{temp[i][j]} ";
                }
                DebugText.Text += '\n';
            }

            return LeftUpperCode(temp, f);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="f"> true == Left to Right    
        /// false == Left to Up</param>
        /// <returns></returns>
        private List<char> LeftBottomCode(List<List<char>> matrix, bool f)
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

            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < temp[i].Count; j++)
                {
                    DebugText.Text += $"{temp[i][j]} ";
                }
                DebugText.Text += '\n';
            }

            return LeftUpperCode(temp, f);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="f"> true == Right to Left    
        /// false == Right to Down</param>
        /// <returns></returns>
        private List<char> RightUpperCode(List<List<char>> matrix, bool f)
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

            for (int i = 0; i < temp.Count; i++)
            {
                for(int j = 0; j < temp[i].Count; j++)
                {
                    DebugText.Text += $"{temp[i][j]} ";
                }
                DebugText.Text += '\n';
            }

            return LeftUpperCode(temp, f);
        }

        #endregion
        
        #region decode

        private List<List<char>> LeftUpperDeCode(List<char> code, bool f, int rowMax, int columnMax)
        {
            List<List<char>> matrix = new List<List<char>>();
                        
            for (int i = 0; i < rowMax; i++)
            {
                matrix.Add(new List<char>());
                for (int j = 0; j < columnMax; j++)
                {
                    matrix[i].Add(' ');
                }
            }
            int max = rowMax * columnMax;
            int counter = 0;
            int p = 0;

            for (int i = 0; i < rowMax; i++)
            {
                if (i > columnMax - 1)
                {
                    counter++;
                }
                for (int j = 0; j < i + 1; j++)
                {
                    if (j > columnMax - 1)
                    {
                        break;
                    }
                    int _row = -1;
                    int _col = -1;

                    int _colEven = -1;

                    if (i > columnMax - 1)
                    {

                        _col = f ? i - j - counter : j;
                        _row = f ? j + counter : i - _col;

                        if ((rowMax % 2 == 0 && columnMax % 2 != 0) || (rowMax % 2 != 0 && columnMax % 2 == 0))
                        {
                            _colEven = f ? j : i - j - counter;
                        }
                    }
                    else
                    {
                        _col = f ? i - j : j;
                        _row = i - _col;
                        if ((rowMax % 2 == 0 && columnMax % 2 != 0) || (rowMax % 2 != 0 && columnMax % 2 == 0))
                        {
                            _colEven = f ? j : i - j;
                        }
                    }

                    

                    matrix[_row][_col] = code[p];

                    if ((rowMax % 2 == 0 && columnMax % 2 != 0) || (rowMax % 2 != 0 && columnMax % 2 == 0))
                    {
                        matrix[rowMax + _colEven - i - 1][columnMax - _colEven - 1] = code[max - p - 1] ;
                    }
                    else
                    {
                        matrix[rowMax + _col - i - 1][columnMax - _col - 1] = code[max - p - 1];
                    }

                    p++;
                }
                f = !f;
            }

            return matrix;
        }

        private List<List<char>> RightUpperDeCode(List<char> code, bool f, int rowMax, int columnMax)
        {
            List<List<char>> matrix = LeftUpperDeCode(code, f, rowMax, columnMax);

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

            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < temp[i].Count; j++)
                {
                    DebugText.Text += $"{temp[i][j]} ";
                }
                DebugText.Text += '\n';
            }

            return temp;
        }
        private List<List<char>> RightBottomDeCode(List<char> code, bool f, int rowMax, int columnMax)
        {
            List<List<char>> matrix = LeftUpperDeCode(code, f, rowMax, columnMax);

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

            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < temp[i].Count; j++)
                {
                    DebugText.Text += $"{temp[i][j]} ";
                }
                DebugText.Text += '\n';
            }

            return temp;
        }
        private List<List<char>> LeftBottomDeCode(List<char> code, bool f, int rowMax, int columnMax)
        {
            List<List<char>> matrix = LeftUpperDeCode(code, f, rowMax, columnMax);

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

            for (int i = 0; i < temp.Count; i++)
            {
                for (int j = 0; j < temp[i].Count; j++)
                {
                    DebugText.Text += $"{temp[i][j]} ";
                }
                DebugText.Text += '\n';
            }

            return temp;
        }

        #endregion
        private List<List<char>> GetMatrixCode()
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

        private void GetMatrixDeCode(out int maxRow, out int maxColumn)
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

            maxRow = c;
            maxColumn = a;
        }
    }
}
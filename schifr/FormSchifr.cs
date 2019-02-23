using System;
using System.Text;
using System.Windows.Forms;

//Дополнительное задание
//Расшифровать сообщение:
//ДМПЯЕ СО СЕ Л ЧПЬВАИЕО.ТНЛ.БУЁТЯЕЯУ
//Ключ: ФОРМУЛИСТ


namespace schifr
{
    public partial class FormSchifr : Form
    {
        //int[] abc;

        public FormSchifr()
        {
            InitializeComponent();
        }    

        private void btSchifr_Click(object sender, EventArgs e)
        {
            if (CheckError().Length > 0)
            {
                MessageBox.Show(CheckError());
                return;
            }                   
            fillGrid1();
            tBoxKeyABC.Text = GetAbc(tBoxKey.Text);
            fillGrid2();
            Shifr();
            tBoxSchifr.Text = Shifr();
            tBoxGetSchifr.Text = Shifr();            
        }

        private string CheckError()
        {
            if (tBoxMessage.Text.Length == 0 || tBoxKey.Text.Length == 0) return "Вы пытаетесь шифровать пустое сообщение или ключ пустой";
            ////заполняем точками если не все влезает в грид
            //while (tBoxMessage.Text.Length % tBoxKey.Text.Length != 0)
            //    tBoxMessage.Text += ".";
            if (IsEqualLetters(tBoxKey.Text))return "В ключе должны быть разные буквы!";                           
            return "";
        }

        private bool IsEqualLetters(string text)  //перебор ключа на предмет одинаковых букв
        {
            for (int i = 0; i < text.Length; i++)
               if (text.Substring(i + 1).IndexOf(text[i]) >= 0) return true;
            return false;
        }

        private void fillGrid1()
        {
          
            AddColumns(grid1, tBoxKey.Text);
            grid1.Rows.Clear();

            int cols = tBoxKey.Text.Length;
            int rows = tBoxMessage.Text.Length / cols;
            if (tBoxMessage.Text.Length % cols>0) rows++;
            grid1.Rows.Add(rows);

            //int row = -1;
            //int col = 0;
            int row=0, col=0;

            for (int i = 0; i < tBoxMessage.Text.Length; i++)
            {
                //col = i % tBoxKey.Text.Length;
                //if (col == 0)
                //{
                //    grid1.Rows.Add();
                //    row++;
                //}
                //grid1[col, row].Value = tBoxMessage.Text.Substring(i, 1);
                col = i % cols;
                row = i / cols;
                grid1[col, row].Value = tBoxMessage.Text[i];
            }

            for (col++; col < tBoxKey.Text.Length; col++)
                grid1[col, row].Value = '.';
        }

        private void AddColumns(DataGridView grid, string letters)
        {
            grid.Columns.Clear();
            for (int i = 0; i < letters.Length; i++)
            {               
                grid.Columns.Add("", letters[i].ToString());
                grid.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;//запрет сортировки колонок
            }
        }

        private void fillGrid2()
        {

            //grid2.Columns.Clear();
            //for (int i = 0; i < tBoxKeyABC.Text.Length; i++)
            //{
            //    grid2.Columns.Add("col_" + i.ToString(), tBoxKeyABC.Text.Substring(i, 1));
            //    grid2.Columns["col_" + i.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;//запрет сортировки колонок
            //}
            AddColumns(grid2, tBoxKeyABC.Text);
            grid2.Rows.Clear();
            grid2.Rows.Add(grid1.RowCount);

            for (int col = 0; col < tBoxKeyABC.Text.Length; col++)
                for (int row = 0; row < grid1.Rows.Count; row++)
                {
                    //grid2[col, row].Value = grid1[abc[col], row].Value;
                    int colAbc = tBoxKey.Text.IndexOf(tBoxKeyABC.Text[col]);
                    grid2[col, row].Value = grid1[colAbc, row].Value;
                }          
            }

        private string Shifr()
        {
            StringBuilder sb = new StringBuilder();
            for (int col = 0; col < grid2.Columns.Count; col++)
                for (int row = 0; row < grid2.Rows.Count; row++)                
                    sb.Append(grid2[col, row].Value);                
            return sb.ToString();            
        }

        /// <summary>
        /// Генерация алфавитного ключа
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string GetAbc(string key)
        {
            //abc = new int[key.Length];
            //for (int i = 0; i < abc.Length; i++)
            //    abc[i] = i;
            //for (int i = 0; i < key.Length; i++)//пузырьковая сортировка
            //    for (int j = 0; j < key.Length - i - 1; j++)
            //        if (key[j] > key[j + 1])
            //        {
            //            key = key.Remove(j, 2).
            //                Insert(j, key.Substring(j + 1, 1)).
            //                Insert(j + 1, key.Substring(j, 1));
            //            int x = abc[j];
            //            abc[j] = abc[j + 1];
            //            abc[j + 1] = x;
            //        }

            char[] arr = key.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
            //return key;
        }


        private void btDeSchifr_Click(object sender, EventArgs e)
        {
            if (tBoxGetKey.Text.Length == 0) return;
            if (tBoxGetSchifr.Text.Length == 0) return;
            tBoxGetMessage.Text = DeShifr();
            tBoxGetKeyAbs.Text = GetAbc(tBoxGetKey.Text);
            fillGrid3();
            fillGrid4();              
        }


        private void fillGrid3()
        {         

            //grid3.Columns.Clear();//подписываем столбцы шифра справа
            //for (int i = 0; i < tBoxGetKeyAbs.Text.Length; i++)
            //{
            //    grid3.Columns.Add("col_" + i.ToString(), tBoxGetKeyAbs.Text.Substring(i, 1));
            //    grid3.Columns["col_" + i.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;//запрет сортировки колонок
            //}
            AddColumns(grid3, tBoxKeyABC.Text);

            grid3.Rows.Clear();
            
            //поверяем условия для заполнения и заполняем таблицу         
            int rows = (tBoxGetSchifr.Text.Length % tBoxGetKey.Text.Length)==0? tBoxGetSchifr.Text.Length / tBoxGetKey.Text.Length : (tBoxGetSchifr.Text.Length / tBoxGetKey.Text.Length)+1;
            //int rows = (tBoxGetSchifr.Text.Length / tBoxGetKey.Text.Length);
            //int rows = 4;
            grid3.Rows.Add(rows);
                        
            int pos = 0;
            for (int col = 0; col < tBoxGetKey.Text.Length; col++)
                for (int row = 0; row < rows; row++)
                {
                   if (pos >= tBoxGetSchifr.Text.Length) grid3[col, row].Value = "";
                   else grid3[col, row].Value = tBoxGetSchifr.Text.Substring(pos++, 1);
                  //  string x = grid3[col, row].Value.ToString();
                  //  MessageBox.Show(x);
                }


            //int col = 0, row=-1;
            //for (int i = 0; i < tBoxGetSchifr.Text.Length; i++)
            //{
            //    col = i % tBoxGetKey.Text.Length;
            //    if (col == 0)
            //    {
            //        grid3.Rows.Add();
            //        row++;
            //    }
            //    grid3[col, row].Value = tBoxGetSchifr.Text.Substring(i, 1);
            //}


        }

        private void fillGrid4()
        {
            AddColumns(grid4, tBoxGetKey.Text);
            //grid4.Columns.Clear();
            //for (int i = 0; i < tBoxGetKey.Text.Length; i++)
            //{
            //    grid4.Columns.Add("col_" + i.ToString(), tBoxGetKey.Text.Substring(i, 1));
            //    grid4.Columns["col_" + i.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;//запрет сортировки колонок
            //}
            grid4.Rows.Clear();
            grid4.Rows.Add(grid3.Rows.Count);

            for (int col = 0; col < tBoxGetKeyAbs.Text.Length; col++)
                for (int row = 0; row < grid4.Rows.Count; row++)
                {
                    //grid4[abc[col], row].Value = grid3[col, row].Value;
                    int colAbc = tBoxGetKeyAbs.Text.IndexOf(tBoxGetKey.Text[col]);
                    grid4[col, row].Value = grid3[colAbc, row].Value;
                }
            string message = DeShifr();          
        }

        private string DeShifr()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < grid4.Rows.Count; row++)
                for (int col = 0; col < tBoxGetKeyAbs.Text.Length; col++)
                    sb.Append(grid4[col, row].Value);
            return sb.ToString();
        }
    }
}

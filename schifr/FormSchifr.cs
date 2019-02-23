using System;
using System.Windows.Forms;

//Дополнительное задание
//Расшифровать сообщение:
//ДМПЯЕ СО СЕ Л ЧПЬВАИЕО.ТНЛ.БУЁТЯЕЯУ
//Ключ: ФОРМУЛИСТ


namespace schifr
{
    public partial class FormSchifr : Form
    {
        int[] abc;

        public FormSchifr()
        {
            InitializeComponent();
        }    

        private void btSchifr_Click(object sender, EventArgs e)
        {
            fillGrid1();
            fillGrid2();
        }

        private void fillGrid1()
        {
            if (tBoxMessage.Text.Length == 0 || tBoxKey.Text.Length == 0) return;
            //заполняем точками если не все влезает в грид
            while (tBoxGetMessage.Text.Length % tBoxKey.Text.Length != 0)
                tBoxMessage.Text += ".";

            grid1.Columns.Clear();
            for (int i = 0; i < tBoxKey.Text.Length; i++)
            {
                grid1.Columns.Add("col_" + i.ToString(), tBoxKey.Text.Substring(i, 1));
                grid1.Columns["col_" + i.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;//запрет сортировки колонок
            }
            grid1.Rows.Clear();

            int row = -1;
            int col = 0;
            for (int i = 0; i < tBoxMessage.Text.Length; i++)
            {
                col = i % tBoxKey.Text.Length;
                if (col == 0)
                {
                    grid1.Rows.Add();
                    row++;
                }
                grid1[col, row].Value = tBoxMessage.Text.Substring(i, 1);
            }
        }

        private void fillGrid2()
        {
            tBoxKeyABC.Text = GetAbc(tBoxKey.Text);
            grid2.Columns.Clear();
            for (int i = 0; i < tBoxKeyABC.Text.Length; i++)
            {
                grid2.Columns.Add("col_" + i.ToString(), tBoxKeyABC.Text.Substring(i, 1));
                grid2.Columns["col_" + i.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;//запрет сортировки колонок
            }
            grid2.Rows.Clear();
            grid2.Rows.Add(grid1.RowCount);

            for (int col = 0; col < tBoxKeyABC.Text.Length; col++)
                for (int row = 0; row < grid1.Rows.Count; row++)
                {
                    grid2[col, row].Value = grid1[abc[col], row].Value;
                }
            string shifr = "";
            for (int col = 0; col < grid2.Columns.Count; col++)
                for (int row = 0; row < grid2.Rows.Count; row++)
                {
                    shifr += grid2[col, row].Value;
                }
            tBoxSchifr.Text = shifr;
            tBoxGetSchifr.Text = shifr;

        }

        /// <summary>
        /// Генерация алфавитного ключа
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private string GetAbc(string key)
        {
            abc = new int[key.Length];
            for (int i = 0; i < abc.Length; i++)
                abc[i] = i;
            for (int i = 0; i < key.Length; i++)//пузырьковая сортировка
                for (int j = 0; j < key.Length - i - 1; j++)
                    if (key[j] > key[j + 1])
                    {
                        key = key.Remove(j, 2).
                            Insert(j, key.Substring(j + 1, 1)).
                            Insert(j + 1, key.Substring(j, 1));
                        int x = abc[j];
                        abc[j] = abc[j + 1];
                        abc[j + 1] = x;
                    }
            return key;
        }


        private void btDeSchifr_Click(object sender, EventArgs e)
        {
            fillGrid3();
            fillGrid4();
        }


        private void fillGrid3()
        {
            if (tBoxGetKey.Text.Length == 0) return;
            if (tBoxGetSchifr.Text.Length == 0) return;

            tBoxGetKeyAbs.Text = GetAbc(tBoxGetKey.Text);
            grid3.Columns.Clear();//подписываем столбцы шифра справа
            for (int i = 0; i < tBoxGetKeyAbs.Text.Length; i++)
            {
                grid3.Columns.Add("col_" + i.ToString(), tBoxGetKeyAbs.Text.Substring(i, 1));
                grid3.Columns["col_" + i.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;//запрет сортировки колонок
            }
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
                    string x = grid3[col, row].Value.ToString();
                    MessageBox.Show(x);
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
            grid4.Columns.Clear();
            for (int i = 0; i < tBoxGetKey.Text.Length; i++)
            {
                grid4.Columns.Add("col_" + i.ToString(), tBoxGetKey.Text.Substring(i, 1));
                grid4.Columns["col_" + i.ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;//запрет сортировки колонок
            }
            grid4.Rows.Clear();
            grid4.Rows.Add(grid3.Rows.Count);

            for (int col = 0; col < tBoxGetKeyAbs.Text.Length; col++)
                for (int row = 0; row < grid4.Rows.Count; row++)
                {
                    grid4[abc[col], row].Value = grid3[col, row].Value;
                }
            string message = "";

            for (int row = 0; row < grid4.Rows.Count; row++)
                for (int col = 0; col < tBoxGetKeyAbs.Text.Length; col++)
                    message += grid4[col, row].Value;
            tBoxGetMessage.Text = message;
        }

    }
}

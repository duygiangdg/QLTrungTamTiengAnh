using DevComponents.DotNetBar.Controls;
using QLTrungTamTiengAnh.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.Component
{
    class XDataGridView : DataGridViewX
    {
        public XDataGridView()
        {
            this.DataBindingComplete += delegate (object o, DataGridViewBindingCompleteEventArgs e)
            {
                BalanceColumnWeights();
            };
        }

        public void Search(string query)
        {
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[this.DataSource];
            currencyManager.SuspendBinding();
            foreach (DataGridViewRow row in this.Rows)
            {
                row.Visible = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().ToUpper().IndexOf(query.ToUpper()) > -1)
                    {
                        row.Visible = true;
                        break;
                    }
                }
            }
            currencyManager.ResumeBinding();
        }

        private void BalanceColumnWeights()
        {
            DataTable table = (DataTable)DataSource;
            int rowCount = table.Rows.Count;
            int colCount = table.Columns.Count;

            this.DataSource = table;
            if (rowCount>0)
            {
                const int turnNumber = 50;
                const int baseWeight = 5;
                const int minWeight = 5;
                const int maxWeight = 30;
                int[] colWeight = new int[colCount];
                Random random = new Random();

                for (int turn = 0; turn < turnNumber; turn++)
                {
                    int randomRow = random.Next(rowCount);
                    for (int colIndex = 0; colIndex < colCount; colIndex++)
                    {
                        if (table.Columns[colIndex].DataType == typeof(DateTime))
                        {
                            colWeight[colIndex] += 10;
                        }
                        else
                        {
                            int length = table.Rows[randomRow].ItemArray[colIndex].ToString().Length;
                            if (length < minWeight)
                            {
                                colWeight[colIndex] += minWeight;
                            }
                            else if (length > maxWeight)
                            {
                                colWeight[colIndex] += maxWeight;
                            }
                            else
                            {
                                colWeight[colIndex] += length;
                            }
                        }
                    }
                }

                for (int colIndex = 0; colIndex < colCount; colIndex++)
                {
                    this.Columns[colIndex].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                    this.Columns[colIndex].FillWeight = colWeight[colIndex] + baseWeight * turnNumber;
                }
            }
        }
    }
}

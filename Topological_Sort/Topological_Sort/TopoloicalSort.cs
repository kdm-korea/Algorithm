using System;
using System.Collections.Generic;
using System.Linq;

namespace Topological_Sort
{
    class TopoloicalSort
    {
        Paragraph paragraph;
        private List<Paragraph> result = new List<Paragraph>();

        public void Execute_TopoloicalSort(Dictionary<string, int> DAG_InDegree) {
            while (DAG_InDegree.Count != 0) {
                BFS_Polling(DAG_InDegree);
            }
        }

        public void Prt_TopologicalSort() {
            foreach (var collect in result) {
                Console.WriteLine("================================================");
                foreach (var val in collect.list) {
                    Console.Write($"{val}   ");
                }
                Console.WriteLine();
            }
        }

        private void BFS_Polling(Dictionary<string, int> DAG_InDegree) {
            paragraph = new Paragraph();
            foreach (string key in DAG_InDegree.Keys.ToList()) {
                if (ChkInDegreeZero(DAG_InDegree, key)) {
                    Insert_BFS_Queue(DAG_InDegree, key);
                }
                else {
                    Polling(DAG_InDegree, key);
                }
            }
            result.Add(paragraph);
        }

        private bool ChkInDegreeZero(Dictionary<string, int> DAG_InDegree, string key) => DAG_InDegree[key] == 0 ? true : false;

        void Insert_BFS_Queue(Dictionary<string, int> DAG_InDegree, string value) {
            paragraph.list.Add(value);
            DAG_InDegree.Remove(value);
        }

        private void Polling(Dictionary<string, int> DAG_InDegree, string key) => DAG_InDegree[key]--;
    }
}

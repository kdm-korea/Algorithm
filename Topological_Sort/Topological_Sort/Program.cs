using System.Collections.Generic;

namespace Topological_Sort
{
    
    class Program
    {
        static Dictionary<string, int> DAG_InDegree = new Dictionary<string, int>();
        static TopoloicalSort topoloicalSort;

        static void Main(string[] args) {
            topoloicalSort = new TopoloicalSort();

            Insert_DAG_InDegree();
            topoloicalSort.Execute_TopoloicalSort(DAG_InDegree);
            topoloicalSort.Prt_TopologicalSort();
        }

        /// <summary>
        /// DAG 그래프(사이클이 없는 그래프)의 진입차수를 갖고 있는 자료
        /// ============================================================
        ///     대학입학(0)
        ///         ↓
        ///     대학졸업(1)       고교졸업(0)      검정고시(0)
        ///        ┌┷┐                ┌┷┐               │
        ///    ┌───┘ └───────┐┌───────┘ └──────┐┌───────┘
        ///    ↓             ↓↓                ↓↓
        /// 대학원(1)       취직(2)          재수(2)
        ///    │               │                │
        ///    └───────────────┼────────────────┘
        ///                    ↓
        ///                 치킨집(3)
        /// Ref : https://m.blog.naver.com/occidere/220921661731
        /// </summary>        
        static void Insert_DAG_InDegree() {
            DAG_InDegree.Add("대학 입학", 0);
            DAG_InDegree.Add("대학 졸업", 1);
            DAG_InDegree.Add("교고 졸업", 0);
            DAG_InDegree.Add("검정 고시", 0);
            DAG_InDegree.Add("대학원", 2);
            DAG_InDegree.Add("취직", 2);
            DAG_InDegree.Add("재수", 1);
            DAG_InDegree.Add("치킨집", 3);
        }
    }
}

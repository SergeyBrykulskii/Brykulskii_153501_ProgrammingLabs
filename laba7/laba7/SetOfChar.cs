using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba7
{
    public class SetOfChar
    {
        private char[] set;
        private char[] Set 
        {
            get => this.set;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    for (int j = i + 1; j < value.Length; j++)
                    {
                        if (value[i] == value[j])
                        {
                            Console.WriteLine("Ошибка! В множестве не должно быть повторяющихся элементов!");
                            throw new Exception("Ошибка! В множестве не должны повторяться элементы!");
                        }
                    }
                }
                this.set = value;
            }
        }

        public SetOfChar(char[] set)
        {
            Set = set;
        }

        public void Print()
        {
            Console.WriteLine("Множество символов:");
            for (int i = 0; i < set.Length; i++)
            {
                Console.Write(set[i] + " ");
            }
            Console.WriteLine();
        }
        public static SetOfChar operator +(SetOfChar set1, SetOfChar set2)
        {
            int numOfNewElements = 0;
            char[] set = new char[set1.Set.Length + set2.Set.Length];
            
            for (int i = 0; i < set1.Set.Length; i++)
            {
                set[i] = set1.Set[i];
            }
            
            for (int i = 0; i < set2.Set.Length; i++)
            {
                for (int j = 0; j < set1.Set.Length; j++)
                {
                    if (set2.Set[i] == set1.Set[j])
                    {
                        break;
                    }
                    if (j == set1.Set.Length - 1)
                    {
                        set[set1.Set.Length + numOfNewElements] = set2.Set[i];
                        numOfNewElements++;
                    }
                }
            }

            char[] newSet = new char[set1.Set.Length + numOfNewElements];

            for (int i = 0; i < set1.Set.Length + numOfNewElements; i++)
            {
                newSet[i] = set[i];
            }

            return new SetOfChar(newSet);
        }



        public static SetOfChar operator -(SetOfChar set1, SetOfChar set2)
        {
            int numOfUnicEl = 0;
            
            char[] set = new char[set1.Set.Length];
            
            for (int i = 0; i < set1.Set.Length; i++)
            {
                set[i] = set1.Set[i];
            }
            
            for (int i = 0; i < set2.Set.Length; i++)
            {
                for (int j = 0; j < set1.Set.Length; j++)
                {
                    if (set2.Set[i] == set1.Set[j])
                    {
                        set[j] = ' ';
                        break;
                    }
                }
            }
            for (int i = 0; i < set.Length; i++)
            {
                if (set[i] != ' ')
                {
                    set[numOfUnicEl] = set[i];
                    numOfUnicEl++;
                }
                
            }
            char[] newSet = new char[numOfUnicEl];
            for (int i = 0; i < numOfUnicEl; i++)
            {
                newSet[i] = set[i];
            }
            return new SetOfChar(newSet);
        }

        public static SetOfChar operator *(SetOfChar set1, SetOfChar set2)
        {
            int numOfComonEl = 0;

            char[] set = new char[set1.Set.Length];

            for (int i = 0; i < set1.Set.Length; i++)
            {
                set[i] = set1.Set[i];
            }

            for (int i = 0; i < set2.Set.Length; i++)
            {
                for (int j = 0; j < set1.Set.Length; j++)
                {
                    if (set2.Set[i] == set1.Set[j])
                    {
                        break;
                    }

                    if (j == set1.Set.Length - 1)
                    {
                        set[i] = ' ';
                    }
                }
            }
            for (int i = 0; i < set.Length; i++)
            {
                if (set[i] != ' ')
                {
                    set[numOfComonEl] = set[i];
                    numOfComonEl++;
                }

            }
            char[] newSet = new char[numOfComonEl];
            for (int i = 0; i < numOfComonEl; i++)
            {
                newSet[i] = set[i];
            }
            return new SetOfChar(newSet);
        }

        public static bool operator ==(SetOfChar set1, SetOfChar set2)
        {
            if (set1.Set.Length != set2.Set.Length)
            {
                return false;
            }
            for (int i = 0; i < set1.Set.Length; i++)
            {
                for (int j = 0; j < set2.Set.Length; j++)
                {
                    if (set1.Set[i] == set2.Set[j])
                    {
                        break;
                    }
                    if (j == set2.Set.Length - 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator !=(SetOfChar set1, SetOfChar set2)
        {
            return !(set1 == set2);
        }

        public static bool operator true(SetOfChar set)
        {
            return set.Set.Length != 0;
        }

        public static bool operator false(SetOfChar set)
        {
            return set.Set.Length == 0;
        }

        public override string? ToString()
        {
            String str = "";

            if (set.Length == 0)
            {
                return "Множество пустое";
            }
            else
            {
                for (int i = 0; i < set.Length; i++)
                {
                    str += set[i] + " ";
                }
                return str;
            }
        }

        public char this[int index]
        {
            get
            {
                if (index >= 0 && index < set.Length)
                {
                    return set[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < set.Length)
                {
                    set[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public static implicit operator string(SetOfChar set)
        {
            string str = "";

            for (int i = 0; i < set.Set.Length; i++)
            {
                str += set.Set[i];
            }
            return str;
        }

        public static explicit operator SetOfChar(string str)
        {
            char[] set = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                set[i] = str[i];
            }
            return new SetOfChar(set);
        }
    }
}

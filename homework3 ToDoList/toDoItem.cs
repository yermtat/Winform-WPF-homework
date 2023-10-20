using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_ToDoList;

public class toDoItem
{
    public string Task { get; set; }
    public DateTime Due { get; set; }
    public DateTime CreationTime { get; set; }

    public override string ToString()
    {
        return $"{CreationTime.ToShortDateString()} — {Due.ToShortDateString()}     {Task}";
    }
}

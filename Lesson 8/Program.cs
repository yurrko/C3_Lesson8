using System;

namespace Lesson_8
{
    class Program
    {
        static void Main( string[] args )
        {
        //Домашнее задание
        //3. Есть таблица Users. Столбцы в ней - Id, Name. Написать SQL-запрос, который выведет имена пользователей, начинающиеся на 'A', и которые //встречаются в таблице более одного раза, и их количество.
            var sql = "SELECT Name, COUNT(Name) Num" +
                      "FROM Users" +
                      "WHERE Name LIKE 'A%'" +
                      "GROUP BY Name" +
                      "HAVING COUNT (Name) > 1";
            //4. Какое результат вывода следующего кода? private enum SomeEnum { First = 4, Second, Third = 7 } static void Main(string[] args) //{ Console.WriteLine((int)SomeEnum.Second); }
            var Answer = 5;
            //5. * Существует таблица:
            //Необходимо сформировать SQL-запрос, выбирающий данные следующим образом:

            var table =
@"
WITH temp_table(id, group_id, descr) AS (
	SELECT 1 'id', 1 'group_id', N'Один' descr UNION ALL
	SELECT 2, 2, N'Два' UNION ALL
	SELECT 3, 1, N'Три'  UNION ALL
	SELECT 4, 2, N'Четыре'  UNION ALL
	SELECT 5, 2, N'Пять'
)
SELECT group_id,
(SELECT CONCAT(descr, ',') from temp_table WHERE group_id = t.group_id FOR XML PATH ('') ) descr
FROM temp_table t
GROUP BY group_id
";
            Console.ReadLine();
        }
    }

}

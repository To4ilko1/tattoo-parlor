# Описание класса ISession
Класс для работы с услугами тату-салона.

## Реализация интерфейса
* +Add (Session: [Session](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Session.md "объект класса Session")): Int — функция, добавляющая сеанс в базу данных. Параметр «[Session](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Session.md "объект класса Session")» — сеанс, который необходимо добавить в БД;
* +Save (Session: [Session](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Session.md "объект класса Session")): Bool — функция, редактирующая данные о сеансе. Параметр «[Session](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Session.md "объект класса Session")» — сеанс, который необходимо редактировать в БД;
* +FindByID(ID: Int): Session — функция, осуществляющая поиск сеанса в базе данных по ID и возвращающая найденный, если такой есть. 
* +Delete(ID: Int): Bool – функция удаляет сеанс
* +GetAllSessions (sorting: string, sortingA: string, filtering: Reader, count: Int, page: Int): List <[Session](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Session.md "объект класса Session")> — функция, возвращающая список всех сеансов с заданными параметрами.
Параметры: 
	* sortintg: string — отвечает, по какому полю будет сортироваться список;
	
	* sortingA: bool — отвечает, по возрастанию или убыванию будут сортироваться элементы;
	
	* filtering: string — отвечает за фильтрацию;
	
	* count: int — отвечает, сколько элементов необходимо показать;
	
	* page: int — отвечает, с какой страницы начинать поиск элементов.

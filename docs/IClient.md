# Описание интерфейса IClient
Интерфейс предназначен для работы с методами класса Client

## Реализация интерфейса
* +Add (Client:[Client](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Client.md "объект класса Client")): Int — функция, добавляющая клиента в базу данных. Параметр «[Client](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Client.md "объект класса Client")» — клиент, которого необходимо добавить в БД;
* +Save (Client: [Client](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Client.md "объект класса Client")): Bool — функция, редактирующая данные о клиенте. Параметр «[Client](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Client.md "объект класса Client")» — клиент, которого необходимо редактировать в БД;
* +FindByID(ID: Int): [Client](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Client.md "объект класса Client") — функция, осуществляющая поиск клиента в базе данных по ID и возвращающая найденный, если такой есть.
* +Delete(ID:Int): Bool – функция удаляет клиента.
* +GetAllClients(sorting: string, sortingA: string, filtering: Reader, count: Int, page: Int): List <[Client](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Client.md "объект класса Client")> — функция, возвращающая всех клиентов, удовлетворяющих заданным параметрам.
Параметры:
	* sortintg: string — отвечает, по какому полю будет сортироваться список;
	* sortingA: bool — отвечает, по возрастанию или убыванию будут сортироваться элементы;
	* filtering: string — отвечает за фильтрацию;
	* count: int — отвечает, сколько элементов необходимо показать;
	* page: int — отвечает, с какой страницы начинать поиск элементов.
* +GetListOfServices(ClientID:Int):List<[Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")> - функция, возвращающая список услуг, которые оказывались клиенту.
* +GetListOfSessions(ClientID:Int):List<[Session](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Session.md "объект класса Session")> - функция, возвращающая список сеансов, проводимых с клиентом.
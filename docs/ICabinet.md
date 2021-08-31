# Описание интерфейса ICabinet
Интерфейс предназначен для работы с методами класса Cabinet

## Реализация интерфейса
* +Add (Cabinet:[Cabinet](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Cabinet.md "объект класса Cabinet")): Int — функция, добавляющая кабинет в базу данных. Параметр «[Cabinet](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Cabinet.md "объект класса Cabinet")» — кабинет, 
который необходимо добавить в БД;
* +AddCabinetService (ServiceID:Int,CabinetID:Int): Int — функция, добавляющая новую услугу кабинету в БД. Параметр ServiceID и CabinetID – ID, по которому будет осуществлен поиск в базе.
* +AddCabinetSession (SessionID:Int,CabinetID:Int): Int — функция, добавляющая новый сеанс в кабинет. Параметр SessionID и CabinetID – ID, по которому будет осуществлен поиск в базе.
* +DelCabinetService(ServiceID:Int,CabinetID:Int): Bool - удаление кабинета у услуги.
* +DelCabinetSession(SessionID:Int,CabinetID:Int): Bool- удаление кабинета у сеанса.
* +Delete(ID:Int): Bool – функция удаляет кабинет.
* +FindByID(ID: Int): [Cabinet](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Cabinet.md "объект класса Cabinet")  — функция, осуществляющая поиск кабинета в базе данных по ID и возвращающая найденный, если такой есть.
* +FindByName(BranchID: Int,Name: String): List<[Cabinet](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Cabinet.md "объект класса Cabinet")>  — функция, осуществляющая поиск кабинета в базе данных по имени и возвращающая список кабинетов, подходящих по условию.
* +GetAllCabinets(sorting: string, sortingA: string, filtering: Reader, count: Int, page: Int): List <[Cabinet](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Cabinet.md "объект класса Cabinet")> — функция, возвращающая список кабинетов. 
Параметры: 
	* sortintg: string — отвечает, по какому полю будет сортироваться список;
  
	* sortingA: bool — отвечает, по возрастанию или убыванию будут сортироваться элементы;
  
	* filtering: string — отвечает за фильтрацию;
  
	* count: int — отвечает, сколько элементов необходимо показать;
  
	* page: int — отвечает, с какой страницы начинать поиск элементов.
* +Save ([Cabinet](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Cabinet.md "объект класса Cabinet")): Bool — функция, редактирующая данные о кабинете. Параметр «[Cabinet](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Cabinet.md "объект класса Cabinet"))» — 
кабинет, который необходимо редактировать в БД;
* +SaveCabinetService(CabinetID:Int,ServiceID:Int): Bool - функция, редактирующая услугу в кабинете.
* +SaveCabinetSession(CabinetID:Int,SessionID:Int): Bool - функция, редактирующая сеанс в кабинете. 
* +GetSessions(CabinetID: Int): List <[Session](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Session.md "объект класса Session")> — функция, возвращающая сеансы данного кабинета.
* +GetListOfServices(CabinetID: Int): List <[Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")> — функция, возвращающая услуги, оказывающиеся в данном кабинете.

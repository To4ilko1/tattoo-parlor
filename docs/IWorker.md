# Описание класса IWorker
Интерфейс предназначен для работы с методами класса Worker

## Реализация интерфейса
* +Add (Worker: [Worker](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Worker.md "объект класса Worker")): Int — функция, добавляющая врача в базу данных. Параметр «[Worker](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Worker.md "объект класса Worker")» — мастер, которого необходимо добавить в БД;
* +Save (Worker: [Worker](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Worker.md "объект класса Worker")): Bool — функция, редактирующая данные о мастере. Параметр «[Worker](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Worker.md "объект класса Worker")» — мастер, которого необходимо редактировать в БД;
* +FindByID(ID: Int): [Worker](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Worker.md "объект класса Worker") — функция, осуществляющая поиск мастера в базе данных по ID и возвращающая найденный, если такой есть. 
* +AddWorkerService(ServiceID: Int, WorkerID: Int): Bool – функция добавляет мастеру услугу в БД. Параметр WorkerID и ServiceID – ID по которому будет осуществлен поиск в базе.
* +Delete(ID: Int): Bool – функция удаляет мастера
* +DelWorkerService(ServiceID: Int, WorkerID:Int):Bool – удаление услуги мастера
* +GetAllWorkers (sorting: string, sortingA: string, filtering: Reader, count: Int, page: Int): List <[Worker](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Worker.md "объект класса Worker")> — функция, возвращающая список всех работников с заданными параметрами.
Параметры: 
	* sortintg: string — отвечает, по какому полю будет сортироваться список;
	* sortingA: bool — отвечает, по возрастанию или убыванию будут сортироваться элементы;
	* filtering: string — отвечает за фильтрацию;
	* count: int — отвечает, сколько элементов необходимо показать;
	* page: int — отвечает, с какой страницы начинать поиск элементов.
* +GetListOfSessions(WorkerID : Int): List<[Session](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Session.md "объект класса Session")> — функция, возвращающая список сеансов, проводимых мастером
* +GetListOfServices(WorkerID : Int): List<[Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")> — функция, возвращающая список услуг, которые оказывает мастер

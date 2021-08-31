# Описание интерфейса IService
Интерфейс предназначен для работы с методами класса Service

## Реализация интерфейса
* +Add (Service:[Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")): Int — функция, добавляющая услугу в базу данных. Параметр «[Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")» — услуга, 
которую необходимо добавить в БД;
* +AddServiceMaterial (ServiceID:Int,MaterialID:Int,Amount:Double): Bool — функция, добавляющая материал и его количество в услугу в БД. Параметр ServiceID и MaterialID – ID, по которому будет осуществлен поиск в базе.
* +DelServiceMaterial(ServiceID:Int,MaterialID:Int): Bool - удаление материала у услуги.
* +Delete(ID:Int): Bool – функция удаляет услугу.
* +FindByID(ID: Int): [Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")  — функция, осуществляющая поиск услуги в базе данных по ID и возвращающая найденную, если такая есть.
* +GetAllServices(sorting: string, sortingA: string, filtering: Reader, count: Int, page: Int): List <[Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")> — функция, возвращающая список услуг. 
Параметры: 
	* sortintg: string — отвечает, по какому полю будет сортироваться список;
  
	* sortingA: bool — отвечает, по возрастанию или убыванию будут сортироваться элементы;
  
	* filtering: string — отвечает за фильтрацию;
  
	* count: int — отвечает, сколько элементов необходимо показать;
  
	* page: int — отвечает, с какой страницы начинать поиск элементов.
* +Save ([Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")): Bool — функция, редактирующая данные о услуге. Параметр «[Service](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Service.md "объект класса Service")» — 
услуга, которую необходимо редактировать в БД;
* +SaveCountMaterial(ServiceID:Int,MaterialID:Int,Amount:Double): Bool - функция, редактирующая количество материала, требующегося для услуги.
* +GetAllWorkers(ServiceID: Int): List <[Worker](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Worker.md "объект класса Worker")> — функция, возвращающая список работников, оказывающих услугу.
* +GetAllMaterials(ServiceID: Int): Dictionary <[Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material"), Double> — функция, возвращающая список материалов, требующихся для услуги.
* +GetListOfBranches(ServiceID:Int):List<[Branch](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Branch.md "объект класса Branch")> - функция, возвращающая список филиалов, где оказывается данная услуга.
# Описание интерфейса IBranch
Интерфейс предназначен для работы с методами класса Branch

## Реализация интерфейса
* +Add (Branch:[Branch](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Branch.md "объект класса Branch")): Int — функция, добавляющая Филиал в базу данных. Параметр «[Branch](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Branch.md "объект класса Branch")» — Филиал, 
который необходимо добавить в БД;
* +AddBranchCabinet (CabinetID:Int,BranchID:Int): Int — функция, добавляющая новый кабинет Филиалу в БД. Параметр CabinetID и BranchID – ID, по которому будет осуществлен поиск в базе.
* +AddBranchMaterial (MaterialID:Int,BranchID:Int): Int — функция, добавляющая новый материал в Филиал. Параметр MaterialID и BranchID – ID, по которому будет осуществлен поиск в базе.
* +DelBranchCabinet(CabinetID:Int,BranchID:Int): Bool - удаление кабинета у филиала.
* +DelBranchMaterial(MaterialID:Int,BranchID:Int,Amount:Double): Bool- удаление материала у филиала.
* +Delete(ID:Int): Bool – функция удаляет Филиал.
* +FindByID(ID: Int): [Branch](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Branch.md "объект класса Branch"))  — функция, осуществляющая поиск Филиала в базе данных по ID и возвращающая найденный, если такой есть.
* +GetAllBranches(sorting: string, sortingA: string, filtering: Reader, count: Int, page: Int): List <[Branch](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Branch.md "объект класса Branch")> — функция, возвращающая список Филиалов. 
Параметры: 
	* sortintg: string — отвечает, по какому полю будет сортироваться список;
  
	* sortingA: bool — отвечает, по возрастанию или убыванию будут сортироваться элементы;
  
	* filtering: string — отвечает за фильтрацию;
  
	* count: int — отвечает, сколько элементов необходимо показать;
  
	* page: int — отвечает, с какой страницы начинать поиск элементов.
* +GetAllMaterials(BranchID:Int):Dictionary<([Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material"),Double> - функция, возвращающая список материалов.
* +Save ([Branch](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Branch.md "объект класса Branch")): Bool — функция, редактирующая данные о Филиале. Параметр «[Branch](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Branch.md "объект класса Branch"))» — 
Филиал, который необходимо редактировать в БД;
* +GetListOfCabinets(BranchID: Int): List <[Cabinet](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Cabinet.md "объект класса Cabinet")> — функция, возвращающая кабинеты Филиала.
* +GetListOfWorkers(BranchID:Int):List<[Worker](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Worker.md "объект класса Worker")> - функция, возвращающая список работников, работающих в филиале.
* +GetVolumeOfMaterialInBranch(BranchID:Int):Dictionary <[Material](https://github.com/To4ilko1/TatooParlor/blob/master/docs/Material.md "объект класса Material"),Double> - функция, возвращающая список материалов и их объемов.
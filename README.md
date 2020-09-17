# BBHT-GA
Optimization Searching Algorithm implemented with Quantum Searching Algorithm and Genetic techniques.

## Grover
![Grover迭代G的线路](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%870.png) 
![Grover搜索算法的线路框家](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%8700.png)
Grover搜索算法在数据库总大小为𝑵、解的个数为𝒕时总时间复杂度为𝑶(√(𝑵∕𝒕))

## BBHT
[BBHT](https://arxiv.org/pdf/quant-ph/9605034.pdf)最优查找算法基于Grover搜索算法，能够解决搜索问题中解的个数未知的情况。其基本思想是确定√𝑁（𝑁为搜索规模）为算法迭代上界，通过不断迭代更新下界，直到找到一个解为止。
BBHT在解的个数不定时找到一个解的时间是𝑂(√(𝑁∕𝑡))
![BBHT算法](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%871.png)  
![BBHT算法应用于0-1背包问题](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%872.png)  

### BBHT-GA & GA 实验对比
![经典遗传算法与BBHT算法迭代次数对比分析及BBHT算法过程中Grover算法迭代次数](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%873.png)
![经典遗传算法与BBHT算法搜索命中率对比及搜索平均适应值/最优适应值对比](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%874.png)

## 量子遗传算法

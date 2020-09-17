# BBHT-GA
Optimization Searching Algorithm implemented with Quantum Searching Algorithm and Genetic techniques.

## 主要工作
（1）	本文复现了重要的量子算法——Grover算法和基于该算法的BBHT算法，通过研究量子计算原理、利用近期推出的Microsoft Q#编程语言及其相应组件让算法得以在Microsoft Visual Studio 2017 平台上运行.
（2）	通过将经典遗传算法与BBHT算法应用0-1背包问题，研究在相同条件下经典算法与量子算法在命中率和收敛速度的表现。
（3）	探究实现了Grover算法在初态为非均匀态时的推广形式。采用一定策略随机产生若干个体形成初始叠加态，并采取重复实验的方法分析Grover推广算法相比原始Grover算法的搜索命中率和加速比（迭代次数比值）。
（4）	在实现了任意初态的Grover推广算法后，引入变异算子，在Grover迭代的过程中对那些搜索表现不佳的种群（叠加态）以一定的预设概率进行变异，并通过重复实验分析变异操作给Grover推广算法带来的搜索效率（如命中率及收敛速度）的变化。研究发现在低量子比特数时，变异算子能够发挥一定的算法优化作用，但随着量子比特数增加这种优化作用在逐渐衰弱。

## Grover
Grover搜索算法在数据库总大小为𝑵、解的个数为𝒕时总时间复杂度为𝑶(√(𝑵∕𝒕))
![Grover迭代G的线路](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%871.png)  
Grover搜索算法的线路框架：  
![Grover搜索算法的线路框架](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%872.png)  
量子搜索算法的线路框架：  
![量子搜索算法的线路框架](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%873.png)

## BBHT
[BBHT](https://arxiv.org/pdf/quant-ph/9605034.pdf)最优查找算法基于Grover搜索算法，能够解决搜索问题中解的个数未知的情况。其基本思想是确定√𝑁（𝑁为搜索规模）为算法迭代上界，通过不断迭代更新下界，直到找到一个解为止。
BBHT在解的个数不定时找到一个解的时间是𝑂(√(𝑁∕𝑡))
![BBHT算法](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%874.png)  
![BBHT算法应用于0-1背包问题](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%875.png)  

### BBHT-GA & GA 实验对比
![经典遗传算法与BBHT算法迭代次数对比分析及BBHT算法过程中Grover算法迭代次数](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%876.png)
![经典遗传算法与BBHT算法搜索命中率对比及搜索平均适应值/最优适应值对比](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%877.png)

## 量子遗传算法
### 随机初始态
方法主要实现初始态为任意叠加态的Grover算法，采用一定的随机策略，利用量子门进行量子态的修改，使得每个个体的几率幅随机化，达到初始态随机的目的。此举目的是利用经典遗传算法中初始种群的性质从而研究需要多少次迭代才能以最大概率得到一个问题的解。
![Grover推广算法生成随机初始态过程](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%878.png)  
![随机初始态的Grover推广算法迭代过程](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%879.png)  
![随机初始态Grover推广算法的命中率与加速比](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%8710.png)  

### 变异算子
因初始几率幅随机，若几率幅分布不如人意，成功搜索（解）能达到的最大概率可能就不那么理想，这是因为对应解的量子态几率幅相对非解量子态的几率幅要低，类似于经典遗传算法中的有效基因缺损，而变异操作增加了物种的多样性，在一定程度上能够改变这个问题。
![Grover推广算法变异操作过程](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%8711.png)  
![带变异算子的随机初始态的Grover推广算法迭代过程](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%8712.png)  
![变异算子对Grover推广算法的优化率和概率增量](https://github.com/ZorrowHu/BBHT-GA/blob/master/BBHT/photo/%E5%9B%BE%E7%89%8713.png)  

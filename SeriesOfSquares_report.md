
# Test Report SeriesOfSquares
### Run Summary

<p>
<strong>Overall Result:</strong> ❌ Fail <br />
<strong>Pass Rate:</strong> 0% <br />
<strong>Run Duration:</strong> 2s 29ms <br />
<strong>Date:</strong> 2021-11-20 08:13:01 - 2021-11-20 08:13:03 <br />
<strong>Framework:</strong> .NETCoreApp,Version=v3.1 <br />
<strong>Total Tests:</strong> 2 <br />
</p>

<table>
<thead>
<tr>
<th>✔️ Passed</th>
<th>❌ Failed</th>
<th>⚠️ Skipped</th>
</tr>
</thead>
<tbody>
<tr>
<td>0</td>
<td>2</td>
<td>0</td>
</tr>
<tr>
<td>0%</td>
<td>100%</td>
<td>0%</td>
</tr>
</tbody>
</table>

### Result Sets
#### Tests.dll - 0%
<details>
<summary>Full Results</summary>
<table>
<thead>
<tr>
<th>Result</th>
<th>Test</th>
<th>Duration</th>
</tr>
</thead>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestSquaredSeries.TestCalculateSumSeries<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
Expected: 14
Actual:   -1</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestSquaredSeries.TestCalculateSumSeries() in /home/runner/work/playground-csharp-xunit-github-action/playground-csharp-xunit-github-action/SeriesOfSquares/Tests/UnitTestSquaredSeries.cs:line 23</code></pre>
</details></blockquote>
</td>
<td>6ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestSquaredSeries.TestSeriesSum<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
Expected: 14
Actual:   -1</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestSquaredSeries.TestSeriesSum() in /home/runner/work/playground-csharp-xunit-github-action/playground-csharp-xunit-github-action/SeriesOfSquares/Tests/UnitTestSquaredSeries.cs:line 13</code></pre>
</details></blockquote>
</td>
<td>< 1ms</td>
</tr>
</tbody>
</table>
</details>

### Run Messages
<details>
<summary>Informational</summary>
<pre><code>
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.3+1b45f5407b (64-bit .NET Core 3.1.1)
[xUnit.net 00:00:00.39]   Discovering: Tests
[xUnit.net 00:00:00.46]   Discovered:  Tests
[xUnit.net 00:00:00.46]   Starting:    Tests
[xUnit.net 00:00:00.56]       Assert.Equal() Failure
[xUnit.net 00:00:00.56]       Expected: 14
[xUnit.net 00:00:00.56]       Actual:   -1
[xUnit.net 00:00:00.56]       Stack Trace:
[xUnit.net 00:00:00.56]         /home/runner/work/playground-csharp-xunit-github-action/playground-csharp-xunit-github-action/SeriesOfSquares/Tests/UnitTestSquaredSeries.cs(23,0): at Tests.UnitTestSquaredSeries.TestCalculateSumSeries()
[xUnit.net 00:00:00.57]       Assert.Equal() Failure
[xUnit.net 00:00:00.57]       Expected: 14
[xUnit.net 00:00:00.57]       Actual:   -1
[xUnit.net 00:00:00.57]       Stack Trace:
[xUnit.net 00:00:00.57]         /home/runner/work/playground-csharp-xunit-github-action/playground-csharp-xunit-github-action/SeriesOfSquares/Tests/UnitTestSquaredSeries.cs(13,0): at Tests.UnitTestSquaredSeries.TestSeriesSum()
[xUnit.net 00:00:00.57]   Finished:    Tests
</code></pre>
</details>

<details>
<summary>Warning</summary>
<pre><code>
</code></pre>
</details>

<details>
<summary>Error</summary>
<pre><code>
[xUnit.net 00:00:00.56]     Tests.UnitTestSquaredSeries.TestCalculateSumSeries [FAIL]
[xUnit.net 00:00:00.57]     Tests.UnitTestSquaredSeries.TestSeriesSum [FAIL]
</code></pre>
</details>



----

[Created using Liquid Test Reports](https://github.com/kurtmkurtm/LiquidTestReports)
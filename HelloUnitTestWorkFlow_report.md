
# Test Report HelloUnitTestWorkFlow
### Run Summary

<p>
<strong>Overall Result:</strong> ❌ Fail <br />
<strong>Pass Rate:</strong> 50% <br />
<strong>Run Duration:</strong> 2s 122ms <br />
<strong>Date:</strong> 2021-11-20 08:36:02 - 2021-11-20 08:36:04 <br />
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
<td>1</td>
<td>1</td>
<td>0</td>
</tr>
<tr>
<td>50%</td>
<td>50%</td>
<td>0%</td>
</tr>
</tbody>
</table>

### Result Sets
#### Tests.dll - 50%
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
<td> ✔️ Passed </td>
<td>Tests.UnitTestMathHelper.TestSummation</td>
<td>5ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestMathHelper.TestSubtraction<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
Expected: 3
Actual:   70</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestMathHelper.TestSubtraction() in /home/runner/work/playground-csharp-xunit-github-action/playground-csharp-xunit-github-action/HelloUnitTestWorkFlow/Tests/UnitTestMathHelper.cs:line 19</code></pre>
</details></blockquote>
</td>
<td>2ms</td>
</tr>
</tbody>
</table>
</details>

### Run Messages
<details>
<summary>Informational</summary>
<pre><code>
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.3+1b45f5407b (64-bit .NET Core 3.1.1)
[xUnit.net 00:00:00.46]   Discovering: Tests
[xUnit.net 00:00:00.53]   Discovered:  Tests
[xUnit.net 00:00:00.53]   Starting:    Tests
[xUnit.net 00:00:00.64]       Assert.Equal() Failure
[xUnit.net 00:00:00.65]       Expected: 3
[xUnit.net 00:00:00.65]       Actual:   70
[xUnit.net 00:00:00.65]       Stack Trace:
[xUnit.net 00:00:00.65]         /home/runner/work/playground-csharp-xunit-github-action/playground-csharp-xunit-github-action/HelloUnitTestWorkFlow/Tests/UnitTestMathHelper.cs(19,0): at Tests.UnitTestMathHelper.TestSubtraction()
[xUnit.net 00:00:00.65]   Finished:    Tests
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
[xUnit.net 00:00:00.64]     Tests.UnitTestMathHelper.TestSubtraction [FAIL]
</code></pre>
</details>



----

[Created using Liquid Test Reports](https://github.com/kurtmkurtm/LiquidTestReports)
/*
 * Copyright (c) 2019 Razeware LLC
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * Notwithstanding the foregoing, you may not use, copy, modify, merge, publish, 
 * distribute, sublicense, create a derivative work, and/or sell copies of the 
 * Software in any work that is designed, intended, or marketed for pedagogical or 
 * instructional purposes related to programming, coding, application development, 
 * or information technology.  Permission for such use, copying, modification,
 * merger, publication, distribution, sublicensing, creation of derivative works, 
 * or sale is expressly withheld.
 *    
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */

using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Collider))]
public class Highlighter : MonoBehaviour
{
    // reference to MeshRenderer component
    private MeshRenderer meshRenderer;

    [SerializeField]
    private Material originalMaterial;

    [SerializeField]
    private Material highlightedMaterial;

    void Start()
    {
        // cache a reference to the MeshRenderer
        meshRenderer = GetComponent<MeshRenderer>(); // 1

        // use non-highlighted material by default
        EnableHighlight(false); // 2
    }

    // toggle betweeen the original and highlighted materials
    public void EnableHighlight(bool onOff)
    {
        if (meshRenderer != null && originalMaterial != null &&
            highlightedMaterial != null) // 3
        {

            meshRenderer.material = onOff ? highlightedMaterial : originalMaterial; // 4
        }
    }

    private void OnMouseOver()
    {
        EnableHighlight(true);
    }

    private void OnMouseExit()
    {
        EnableHighlight(false);
    }

}

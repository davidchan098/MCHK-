/*
 * Created by SharpDevelop.
 * User: user
 * Date: 10/8/2013
 * Time: 11:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MirroredTabControl
{
  /// <summary>
  /// Summary description for MirroredTabControl.
  /// </summary>
  public class MirroredTabControl : System.Windows.Forms.TabControl
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public MirroredTabControl()
    {
      // This call is required by the Windows.Forms Form Designer.
      InitializeComponent();

      // TODO: Add any initialization after the InitializeComponent call

    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if(components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

    #region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
    }
    #endregion

    protected override CreateParams CreateParams
    {
      get
      {
        const int WS_EX_LAYOUTRTL  = 0x400000;
        const int WS_EX_NOINHERITLAYOUT = 0x100000;
        CreateParams cp = base.CreateParams;
        if (this.Mirror)
          cp.ExStyle = cp.ExStyle|WS_EX_LAYOUTRTL|WS_EX_NOINHERITLAYOUT;
        return cp;
      }
    }


    private bool m_Mirror = false;

    [DefaultValue(false)]
    public bool Mirror
    {
      get
      {
        return m_Mirror;
      }
      set
      {
        if (m_Mirror == value) return;
        m_Mirror = value;
        base.UpdateStyles();
      }
    }


  }
}
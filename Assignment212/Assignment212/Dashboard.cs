using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Assignment212
{
	public partial class Dashboard : Form
	{
		// Dashboard controls
		private Label lblTotalPatients;
		private Label lblTodayAppointments;
		private Label lblTotalDoctors;
		private Label lblCompletedAppointments;

		private DataGridView dgvTodayAppointments;
		private DataGridView dgvRecentPatients;

		private Panel panelStats;
		private Panel panelCharts;
		private Panel panelGrids;
		private Timer refreshTimer;

		public Dashboard()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Size = new Size(1000, 700); 
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			InitializeDashboardControls();
			SetupRefreshTimer();
		}

		private void InitializeDashboardControls()
		{
			
			// this.WindowState = FormWindowState.Maximized;
			this.Text = "Hospital Dashboard - Patients, Appointments & Doctors";
			this.BackColor = Color.FromArgb(245, 247, 250);

			//main panels
			CreateMainPanels();

			//statistics section
			CreateStatisticsSection();

            //data grids section
            CreateDataGridsSection();

			// Load initial data
			LoadDashboardData();
		}

		private void CreateMainPanels()
		{
			// Statistics panel
			panelStats = new Panel
			{
				Location = new Point(10, 10),
				Size = new Size(this.ClientSize.Width - 20, 100),
				BackColor = Color.White,
				BorderStyle = BorderStyle.FixedSingle,
				Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
			};
			this.Controls.Add(panelStats);


            // Data grids panel
            panelGrids = new Panel
			{
				Location = new Point(10, 120),
				Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 130),
				BackColor = Color.White,
				BorderStyle = BorderStyle.FixedSingle,
				Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
			};
			this.Controls.Add(panelGrids);

        }

		private void CreateStatisticsSection()
		{
			// Title
			Label titleStats = new Label
			{
				Text = "Key Statistics",
				Font = new Font("Segoe UI", 12, FontStyle.Bold),
				Location = new Point(15, 8),
				AutoSize = true,
				ForeColor = Color.FromArgb(52, 73, 94)
			};
			panelStats.Controls.Add(titleStats);

			
			int cardWidth = (panelStats.Width - 80) / 4; 
			int cardHeight = 60;
			int startY = 30;
			int spacing = 15;

			// Statistics cards
			CreateStatCard("Total Patients", "0", Color.FromArgb(52, 152, 219), new Point(15, startY), cardWidth, cardHeight, out lblTotalPatients);
			CreateStatCard("Today's Appointments", "0", Color.FromArgb(46, 204, 113), new Point(15 + cardWidth + spacing, startY), cardWidth, cardHeight, out lblTodayAppointments);
			CreateStatCard("Total Doctors", "0", Color.FromArgb(155, 89, 182), new Point(15 + (cardWidth + spacing) * 2, startY), cardWidth, cardHeight, out lblTotalDoctors);
			CreateStatCard("Completed Today", "0", Color.FromArgb(230, 126, 34), new Point(15 + (cardWidth + spacing) * 3, startY), cardWidth, cardHeight, out lblCompletedAppointments);
		}

		private void CreateStatCard(string title, string value, Color color, Point location, int width, int height, out Label valueLabel)
		{
			Panel statCard = new Panel
			{
				Location = location,
				Size = new Size(width, height),
				BackColor = color,
				BorderStyle = BorderStyle.None,
				Anchor = AnchorStyles.Top | AnchorStyles.Left
			};

			Label titleLabel = new Label
			{
				Text = title,
				ForeColor = Color.White,
				Font = new Font("Segoe UI", 8, FontStyle.Bold),
				Location = new Point(10, 8),
				Size = new Size(width - 20, 15),
				TextAlign = ContentAlignment.MiddleCenter
			};

			valueLabel = new Label
			{
				Text = value,
				ForeColor = Color.White,
				Font = new Font("Segoe UI", 16, FontStyle.Bold),
				Location = new Point(10, 25),
				Size = new Size(width - 20, 25),
				TextAlign = ContentAlignment.MiddleCenter
			};

			statCard.Controls.Add(titleLabel);
			statCard.Controls.Add(valueLabel);
			panelStats.Controls.Add(statCard);
		}

		private void CreateChartsSection()
		{
			// Title
			Label titleCharts = new Label
			{
				Text = "Analytics Overview",
				Font = new Font("Segoe UI", 12, FontStyle.Bold),
				Location = new Point(15, 8),
				AutoSize = true,
				ForeColor = Color.FromArgb(52, 73, 94)
			};
			panelCharts.Controls.Add(titleCharts);

			
			Label noChartsLabel = new Label
			{
				Text = "Charts section available for future analytics",
				Font = new Font("Segoe UI", 10, FontStyle.Italic),
				Location = new Point(15, 50),
				Size = new Size(panelCharts.Width - 30, 30),
				ForeColor = Color.Gray,
				TextAlign = ContentAlignment.MiddleCenter
			};
			panelCharts.Controls.Add(noChartsLabel);
		}

		private void CreateDataGridsSection()
		{
			// Title
			Label titleGrids = new Label
			{
				Text = "Current Data",
				Font = new Font("Segoe UI", 12, FontStyle.Bold),
				Location = new Point(15, 8),
				AutoSize = true,
				ForeColor = Color.FromArgb(52, 73, 94)
			};
			panelGrids.Controls.Add(titleGrids);

			// Today's Appointments Grid
			CreateTodayAppointmentsGrid();

			// Recent Patients Grid
			CreateRecentPatientsGrid();
		}

		private void CreateTodayAppointmentsGrid()
		{
			Label lblTodayTitle = new Label
			{
				Text = "Today's Appointments",
				Font = new Font("Segoe UI", 10, FontStyle.Bold),
				Location = new Point(15, 30),
				AutoSize = true,
				ForeColor = Color.FromArgb(52, 73, 94)
			};
			panelGrids.Controls.Add(lblTodayTitle);

			int gridWidth = (panelGrids.Width - 45) / 2;
			int gridHeight = panelGrids.Height - 55;

			dgvTodayAppointments = new DataGridView
			{
				Location = new Point(15, 50),
				Size = new Size(gridWidth, gridHeight),
				BackgroundColor = Color.White,
				BorderStyle = BorderStyle.Fixed3D,
				AllowUserToAddRows = false,
				AllowUserToDeleteRows = false,
				ReadOnly = true,
				SelectionMode = DataGridViewSelectionMode.FullRowSelect,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
				Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom,
				ColumnHeadersHeight = 30,
				RowTemplate = { Height = 25 }
			};

			StyleDataGridView(dgvTodayAppointments);
			panelGrids.Controls.Add(dgvTodayAppointments);
		}

		private void CreateRecentPatientsGrid()
		{
			Label lblPatientsTitle = new Label
			{
				Text = "Recent Patients",
				Font = new Font("Segoe UI", 10, FontStyle.Bold),
				Location = new Point(30 + (panelGrids.Width - 45) / 2, 30),
				AutoSize = true,
				ForeColor = Color.FromArgb(52, 73, 94),
				Anchor = AnchorStyles.Top | AnchorStyles.Right
			};
			panelGrids.Controls.Add(lblPatientsTitle);

			int gridWidth = (panelGrids.Width - 45) / 2;
			int gridHeight = panelGrids.Height - 55;

			dgvRecentPatients = new DataGridView
			{
				Location = new Point(30 + gridWidth, 50),
				Size = new Size(gridWidth, gridHeight),
				BackgroundColor = Color.White,
				BorderStyle = BorderStyle.Fixed3D,
				AllowUserToAddRows = false,
				AllowUserToDeleteRows = false,
				ReadOnly = true,
				SelectionMode = DataGridViewSelectionMode.FullRowSelect,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
				Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
				ColumnHeadersHeight = 30,
				RowTemplate = { Height = 25 }
			};

			StyleDataGridView(dgvRecentPatients);
			panelGrids.Controls.Add(dgvRecentPatients);
		}

		private void StyleDataGridView(DataGridView dgv)
		{
			dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
			dgv.DefaultCellStyle.SelectionForeColor = Color.White;
			dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
			dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94);
			dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
			dgv.EnableHeadersVisualStyles = false;
			dgv.RowHeadersVisible = false;
			dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
			dgv.GridColor = Color.FromArgb(230, 230, 230);
			dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
		}

		private void SetupRefreshTimer()
		{
			refreshTimer = new Timer
			{
				Interval = 60000 // Refresh every minute
			};
			refreshTimer.Tick += RefreshTimer_Tick;
			refreshTimer.Start();
		}

		private void RefreshTimer_Tick(object sender, EventArgs e)
		{
			LoadDashboardData();
		}

		private void LoadDashboardData()
		{
			try
			{
				// Fill tables with data
				if (this.taAppointments != null)
					this.taAppointments.Fill(this.ist2ibDataSet.APPOINTMENTS);

				if (this.taPatients != null)
					this.taPatients.Fill(this.ist2ibDataSet.PATIENTS);

				if (this.taDoctors != null)
					this.taDoctors.Fill(this.ist2ibDataSet.DOCTOR);

				
				LoadStatistics();
				LoadTodayAppointments();
				LoadRecentPatients();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error refreshing dashboard: {ex.Message}", "Database Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadStatistics()
		{
			try
			{
				// Total Patients
				lblTotalPatients.Text = this.ist2ibDataSet.PATIENTS.Count.ToString();

				// Today's Appointments
				DateTime today = DateTime.Today;
				int todayCount = 0;
				int completedTodayCount = 0;

				foreach (DataRow row in this.ist2ibDataSet.APPOINTMENTS.Rows)
				{
					if (!row.IsNull("AppointmentDate"))
					{
						if (DateTime.TryParse(row["AppointmentDate"].ToString(), out DateTime appointmentDate))
						{
							if (appointmentDate.Date == today)
							{
								todayCount++;

								
								if (!row.IsNull("Status") &&
									row["Status"].ToString().Equals("Completed", StringComparison.OrdinalIgnoreCase))
								{
									completedTodayCount++;
								}
							}
						}
					}
				}

				lblTodayAppointments.Text = todayCount.ToString();
				lblCompletedAppointments.Text = completedTodayCount.ToString();

				// Total Doctors
				lblTotalDoctors.Text = this.ist2ibDataSet.DOCTOR.Count.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading statistics: {ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadTodayAppointments()
		{
			try
			{
				var todayAppointments = new List<object>();

				foreach (DataRow appointment in this.ist2ibDataSet.APPOINTMENTS.Rows)
				{
					if (!appointment.IsNull("AppointmentDate"))
					{
						DateTime appointmentDate;
					if (DateTime.TryParse(appointment["AppointmentDate"].ToString(), out appointmentDate))
						{
							if (appointmentDate.Date == DateTime.Today)
							{
								// Find patient
								string patientName = "Unknown";
								if (!appointment.IsNull("PatientID"))
								{
									string patientIdStr = appointment["PatientID"].ToString();
									var patientRow = this.ist2ibDataSet.PATIENTS.AsEnumerable()
										.FirstOrDefault(p => !p.IsNull("PatientID") && p["PatientID"].ToString() == patientIdStr);
									if (patientRow != null && !patientRow.IsNull("Name"))
									{
										patientName = patientRow["Name"].ToString();
									}
								}

								// Find doctor
								string doctorName = "Unknown";
								if (!appointment.IsNull("DoctorID"))
								{
									string doctorIdStr = appointment["DoctorID"].ToString();
									var doctorRow = this.ist2ibDataSet.DOCTOR.AsEnumerable()
										.FirstOrDefault(d => !d.IsNull("DoctorID") && d["DoctorID"].ToString() == doctorIdStr);
									if (doctorRow != null && !doctorRow.IsNull("DoctorName"))
									{
										doctorName = doctorRow["DoctorName"].ToString();
									}
								}

								string time = "Not Set";
								if (!appointment.IsNull("AppointmentTime"))
								{
									var timeValue = appointment["AppointmentTime"];
									if (timeValue is TimeSpan timeSpan)
									{
										time = timeSpan.ToString(@"hh\:mm");
									}
									else if (DateTime.TryParse(timeValue.ToString(), out DateTime dateTime))
									{
										time = dateTime.ToString("HH:mm");
									}
									else
									{
										time = timeValue.ToString();
									}
								}

								string status = appointment.IsNull("Status") ? "Pending" : appointment["Status"].ToString();

								todayAppointments.Add(new
								{
									Time = time,
									Patient = patientName,
									Doctor = doctorName,
									Status = status
								});
							}
						}
					}
				}

				
				todayAppointments = todayAppointments.OrderBy(a => ((dynamic)a).Time).ToList();
				dgvTodayAppointments.DataSource = todayAppointments;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading today's appointments: {ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				dgvTodayAppointments.DataSource = new List<object>();
			}
		}

		private void LoadRecentPatients()
		{
			try
			{
				var recentPatients = new List<object>();

				
				var allPatients = new List<DataRow>();
				foreach (DataRow row in this.ist2ibDataSet.PATIENTS.Rows)
				{
					if (!row.IsNull("PatientID"))
					{
						allPatients.Add(row);
					}
				}

				// Sort by PatientID 
				var sortedPatients = allPatients.OrderByDescending(row =>
				{
					if (int.TryParse(row["PatientID"].ToString(), out int id))
						return id;
					else
						return 0;
				}).Take(10);

				foreach (var patient in sortedPatients)
				{
					string patientName = patient.IsNull("Name") ? "Unknown" : patient["Name"].ToString();
					string patientId = patient["PatientID"].ToString();

					recentPatients.Add(new
					{
						ID = patientId,
						Name = patientName
					});
				}

				dgvRecentPatients.DataSource = recentPatients;

				// Hide ID column
				if (dgvRecentPatients.Columns["ID"] != null)
					dgvRecentPatients.Columns["ID"].Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error loading recent patients: {ex.Message}", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				dgvRecentPatients.DataSource = new List<object>();
			}
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			LoadDashboardData();
		}

		private void Dashboard_Resize(object sender, EventArgs e)
		{
			if (panelStats != null && this.WindowState != FormWindowState.Minimized)
			{
				
				panelStats.Size = new Size(this.ClientSize.Width - 20, 100);
				panelCharts.Size = new Size(this.ClientSize.Width - 20, 280);
				panelGrids.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 420);

				
				int cardWidth = Math.Max(150, (panelStats.Width - 80) / 4);
				int spacing = 15;
				int startX = 15;

				var statCards = panelStats.Controls.OfType<Panel>().ToArray();
				for (int i = 0; i < statCards.Length; i++)
				{
					statCards[i].Size = new Size(cardWidth, 60);
					statCards[i].Location = new Point(startX + i * (cardWidth + spacing), 30);

					
					foreach (Label lbl in statCards[i].Controls.OfType<Label>())
					{
						lbl.Size = new Size(cardWidth - 20, lbl.Size.Height);
					}
				}

			
				int gridWidth = Math.Max(250, (panelGrids.Width - 45) / 2);
				int gridHeight = Math.Max(150, panelGrids.Height - 55);

				if (dgvTodayAppointments != null)
				{
					dgvTodayAppointments.Size = new Size(gridWidth, gridHeight);
				}
				if (dgvRecentPatients != null)
				{
					dgvRecentPatients.Size = new Size(gridWidth, gridHeight);
					dgvRecentPatients.Location = new Point(30 + gridWidth, 50);

					// Update label position
					var lblPatients = panelGrids.Controls.OfType<Label>()
						.FirstOrDefault(l => l.Text == "Recent Patients");
					if (lblPatients != null)
					{
						lblPatients.Location = new Point(30 + gridWidth, 30);
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				refreshTimer?.Stop();
				this.Close();
			}
		}
	}
}